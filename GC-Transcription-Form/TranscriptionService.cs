using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Google.Cloud.Speech.V1;

namespace GC_Transcription_Form
{
    public class TranscriptorConfig
    {
        public string GoogleCloudCredentialsPath { get; set; }
        public string GoogleCloudAudioBucketUrl { get; set; }
        public string AudioFileDirectory { get; set; }
        public string TranscriptionOutputDirectory { get; set; }
        public bool EnhancedSpeaker { get; set; }
        public bool Punctuation { get; set; }
        public bool Profanity { get; set; }
        public bool WordTimeOffset { get; set; }
        public bool SeperateAudioChannel { get; set; }
        public decimal AudioChannelCount { get; set; }
        public string ModelType { get; set; }
        public string LanguageCode { get; set; }
        public bool SpeakerDiarization { get; set; }
        public decimal MinSpeakers { get; set; }
        public decimal MaxSpeakers { get; set; }
        public bool SpeechContext { get; set; }
        public string SpeechContextFilePath { get; set; }
        public string AudioFileType { get; set; }
    }

    public interface ITranscriptionService
    {
        void BeginTranscription(TranscriptorConfig transcriptorConfig);
    }

    class TranscriptionService : ITranscriptionService
    {
        private TranscriptorConfig _transcriptorConfig;

        public void BeginTranscription(TranscriptorConfig transcriptorConfig)
        {
            //set config
            _transcriptorConfig = transcriptorConfig;
            //get every audio file to be transcribed
            string[] filePaths = Directory.GetFiles(transcriptorConfig.AudioFileDirectory);
            foreach (string filePath in filePaths)
            {
                string audioFileName = Path.GetFileName(filePath);
                string transcriptionFileName = audioFileName.Replace("mp3", "txt");
                //check if transcription has already been made
                if (File.Exists(_transcriptorConfig.TranscriptionOutputDirectory + transcriptionFileName) == true) { continue; }
                //send file to the API and get back a transcript
                List<string> transcriptLines = LongSpeechToTextTranscription(_transcriptorConfig, audioFileName);
                //write all lines for that file into a text document
                File.WriteAllLines(_transcriptorConfig.TranscriptionOutputDirectory + transcriptionFileName, transcriptLines);
                Console.WriteLine($"Your completed transcription has been stored here:" + _transcriptorConfig.TranscriptionOutputDirectory + transcriptionFileName);
            }
        }

        //based on code from GoogleCloudPlatform/dotnet-docs-samples/speech/api/Recognize/Recognize.cs
        private List<string> LongSpeechToTextTranscription(TranscriptorConfig transcriptorConfig, string audioFileName)
        {
            List<string> transcriptLines = new List<string>();
            SpeechClientBuilder speechClientBuilder = new SpeechClientBuilder();
            //Credentials document provided by Google
            speechClientBuilder.CredentialsPath = transcriptorConfig.GoogleCloudCredentialsPath;
            SpeechClient speech = speechClientBuilder.Build();
            var longOperation = speech.LongRunningRecognize(new RecognitionConfig()
            {//main config for API request
                Encoding = RecognitionConfig.Types.AudioEncoding.EncodingUnspecified,
                SampleRateHertz = 44100,
                UseEnhanced = transcriptorConfig.EnhancedSpeaker,
                LanguageCode = transcriptorConfig.LanguageCode,
                EnableAutomaticPunctuation = transcriptorConfig.Punctuation,
                Model = transcriptorConfig.ModelType,
                DiarizationConfig = new SpeakerDiarizationConfig
                {
                    EnableSpeakerDiarization = true,
                    MinSpeakerCount = 3,
                    MaxSpeakerCount = 3
                }
            }, RecognitionAudio.FromStorageUri(transcriptorConfig.GoogleCloudAudioBucketUrl + audioFileName)); ; ;
            while (longOperation.IsCompleted == false)
            {
                var rpc = longOperation.Client.GetOperation(longOperation.RpcMessage.Name);
                rpc.Metadata.TryUnpack(out LongRunningRecognizeMetadata metadata);
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