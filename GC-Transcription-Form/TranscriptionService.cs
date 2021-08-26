using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Google.Cloud.Speech.V1;

namespace GC_Transcription_Form
{
    //A struct to handle all the user inputs
    public struct TranscriptorConfig
    {
        public string GoogleCloudCredentialsPath { get; set; }
        public string GoogleCloudAudioBucketUrl { get; set; }
        public string AudioFileDirectory { get; set; }
        public string TranscriptionOutputDirectory { get; set; }
        public int APIUpdateDelay { get; set; }
        public bool EnhancedSpeaker { get; set; }
        public bool Punctuation { get; set; }
        public bool Profanity { get; set; }
        public bool WordTimeOffset { get; set; }
        public bool SeperateAudioChannel { get; set; }
        public int AudioChannelCount { get; set; }
        public string ModelType { get; set; }
        public string LanguageCode { get; set; }
        public bool SpeakerDiarization { get; set; }
        public int MinSpeakers { get; set; }
        public int MaxSpeakers { get; set; }
        public bool SpeechContext { get; set; }
        public string SpeechContextFilePath { get; set; }
        public string AudioFileType { get; set; }
    }

    //DI interface for the TranscriptionApplicationForm class
    public interface ITranscriptionService
    {
        void BeginTranscription(TranscriptorConfig transcriptorConfig);
        string GetTranscriptionProgressString();
        int GetTranscriptionProgressInt();
    }

    class TranscriptionService : ITranscriptionService
    {
        private TranscriptorConfig _transcriptorConfig;
        private RecognitionConfig _recognitionConfig;
        private string transcriptionUpdateString;
        private int transcriptionUpdateInt;

        public void BeginTranscription(TranscriptorConfig transcriptorConfig)
        {
            //set config
            _transcriptorConfig = transcriptorConfig;
            //set up recognitionConfig for the API
            _recognitionConfig = GetRecognitionConfig();
            //get every audio file to be transcribed
            string[] filePaths = Directory.GetFiles(transcriptorConfig.AudioFileDirectory);
            foreach (string filePath in filePaths)
            {
                string audioFileName = Path.GetFileName(filePath);
                string transcriptionFileName = audioFileName.Replace("mp3", "txt");
                //check if transcription has already been made
                if (File.Exists(_transcriptorConfig.TranscriptionOutputDirectory + transcriptionFileName) == true) { continue; }
                //send file to the API and get back a transcript
                List<string> transcriptLines = LongSpeechToTextTranscription(audioFileName);
                //write all lines for that file into a text document
                File.WriteAllLines(_transcriptorConfig.TranscriptionOutputDirectory + transcriptionFileName, transcriptLines);
                Console.WriteLine($"Your completed transcription has been stored here:" + _transcriptorConfig.TranscriptionOutputDirectory + transcriptionFileName);
            }
        }

        public string GetTranscriptionProgressString()
        {
            return transcriptionUpdateString;
        }

        public int GetTranscriptionProgressInt()
        {
            return transcriptionUpdateInt;
        }

        //getting the necessary data from the config struct into Google's RecognitionAudio class
        private RecognitionConfig GetRecognitionConfig()
        {
            SpeakerDiarizationConfig speakerDiarizationConfig = new SpeakerDiarizationConfig()
            {
                EnableSpeakerDiarization = _transcriptorConfig.SpeakerDiarization,
                MinSpeakerCount = _transcriptorConfig.MinSpeakers,
                MaxSpeakerCount = _transcriptorConfig.MaxSpeakers
            };

            RecognitionConfig recognitionConfig = new RecognitionConfig()
            {
                UseEnhanced = _transcriptorConfig.EnhancedSpeaker,
                EnableAutomaticPunctuation = _transcriptorConfig.Punctuation,
                ProfanityFilter = _transcriptorConfig.Profanity,
                EnableWordTimeOffsets = _transcriptorConfig.WordTimeOffset,
                EnableSeparateRecognitionPerChannel = _transcriptorConfig.SeperateAudioChannel,
                AudioChannelCount = _transcriptorConfig.AudioChannelCount,
                Model = _transcriptorConfig.ModelType,
                LanguageCode = _transcriptorConfig.LanguageCode,
                DiarizationConfig = speakerDiarizationConfig
            };
            return recognitionConfig;
        }

        //based on code from GoogleCloudPlatform/dotnet-docs-samples/speech/api/Recognize/Recognize.cs
        private List<string> LongSpeechToTextTranscription(string audioFileName)
        {
            List<string> transcriptLines = new List<string>();
            SpeechClientBuilder speechClientBuilder = new SpeechClientBuilder();
            //Credentials document provided by Google API
            speechClientBuilder.CredentialsPath = _transcriptorConfig.GoogleCloudCredentialsPath;
            SpeechClient speech = speechClientBuilder.Build();
            var longOperation = speech.LongRunningRecognize(_recognitionConfig, RecognitionAudio.FromStorageUri(_transcriptorConfig.GoogleCloudAudioBucketUrl + audioFileName));
            while (longOperation.IsCompleted == false)
            {
                var rpc = longOperation.Client.GetOperation(longOperation.RpcMessage.Name);
                rpc.Metadata.TryUnpack(out LongRunningRecognizeMetadata metadata);
                if (metadata != null)
                {
                    //transcriptionUpdate = $"{DateTime.Now}: {audioFileName} is {metadata.ProgressPercent}% complete...";
                }
                if (rpc.Done == true)
                {
                    longOperation = longOperation.PollOnce();
                }
                Thread.Sleep(_transcriptorConfig.APIUpdateDelay);
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