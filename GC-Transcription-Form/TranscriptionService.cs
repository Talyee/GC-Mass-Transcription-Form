using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Google.Cloud.Speech.V1;
using Newtonsoft.Json;

namespace GC_Transcription_Form
{
    public class Config
    {
        public string GoogleCloudCredentialsPath { get; set; }
        public string GoogleCloudAudioBucketUrl { get; set; }
        public string AudioFileDirectory { get; set; }
        public string AudioFileType { get; set; }
        public string TranscriptionOutputDirectory { get; set; }
    }

    class TranscriptionService
    {
        public TranscriptionService()
        {
            //get config from json
            string jsonString = File.ReadAllText("C:/Users/Tim/source/repos/BFStranscribe/BFStranscribe/config.json");
            Config config = JsonConvert.DeserializeObject<Config>(jsonString);

            //get the every audio file to be transcribed
            string[] filePaths = Directory.GetFiles(config.AudioFileDirectory, "*" + config.AudioFileType);
            foreach (string filePath in filePaths)
            {
                string audioFileName = Path.GetFileName(filePath);
                string transcriptionFileName = audioFileName.Replace("mp3", "txt");
                //check if transcription has already been made
                if (File.Exists(config.TranscriptionOutputDirectory + transcriptionFileName) == true) { continue; }
                //send file to the API and get back a transcript
                List<string> transcriptLines = LongSpeechToTextTranscription(config, audioFileName);
                //write all lines for that file into a text document
                File.WriteAllLines(config.TranscriptionOutputDirectory + transcriptionFileName, transcriptLines);
                Console.WriteLine($"Your completed transcription has been stored here:" + config.TranscriptionOutputDirectory + transcriptionFileName );
            }
        }

        //based on code from GoogleCloudPlatform/dotnet-docs-samples/speech/api/Recognize/Recognize.cs
        private List<string> LongSpeechToTextTranscription(Config config, string audioFileName)
        {
            List<string> transcriptLines = new List<string>();
            SpeechClientBuilder speechClientBuilder = new SpeechClientBuilder();
            //Credentials document provided by Google
            speechClientBuilder.CredentialsPath = config.GoogleCloudCredentialsPath;
            var speech = speechClientBuilder.Build();
            var longOperation = speech.LongRunningRecognize(new RecognitionConfig()
            {//main config for API request
                Encoding = RecognitionConfig.Types.AudioEncoding.EncodingUnspecified,
                SampleRateHertz = 44100,
                LanguageCode = "en-US",
                EnableAutomaticPunctuation = true,
                UseEnhanced = true,
                Model = "phone_call",
                DiarizationConfig = new SpeakerDiarizationConfig
                {
                    EnableSpeakerDiarization = true,
                    MinSpeakerCount = 3,
                    MaxSpeakerCount = 3
                }
            }, RecognitionAudio.FromStorageUri(config.GoogleCloudAudioBucketUrl + audioFileName));
            while (longOperation.IsCompleted == false)
            {
                var rpc = longOperation.Client.GetOperation(longOperation.RpcMessage.Name);
                rpc.Metadata.TryUnpack(out LongRunningRecognizeMetadata  metadata);
                if (metadata != null)
                {
                    Console.WriteLine($"{DateTime.Now}: {audioFileName} is {metadata.ProgressPercent}% complete...");
                }
                if (rpc.Done == true)
                {
                    longOperation = longOperation.PollOnce();
                }
                Thread.Sleep(30000); //remove magic number lmao
            }
            var response = longOperation.Result;
            //seperates it all into individual lines said for a better transcription to file
            foreach (var result in response.Results)
            {
                foreach (var alternative in result.Alternatives)
                {
                    transcriptLines.Add(alternative.Transcript);
                }
            }
            //return the list of transcripted lines
            return transcriptLines;
        }
    }
}