using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Speech.V1;
using System.Text.RegularExpressions;

namespace GC_Transcription_Form
{

    class DummyTranscriptionService : ITranscriptionService
    {
        private TranscriptorConfig _transcriptorConfig;
        private RecognitionConfig _recognitionConfig;
        private string transcriptionUpdateString;
        private int transcriptionUpdateInt;

        public async void BeginTranscription(TranscriptorConfig transcriptorConfig)
        {
            //set config
            _transcriptorConfig = transcriptorConfig;
            //set up recognitionConfig for the API
            _recognitionConfig = GetRecognitionConfig();
            //get every audio file to be transcribed
            string[] filePaths = Directory.GetFiles(_transcriptorConfig.AudioFileDirectory);
            foreach (string filePath in filePaths)
            {
                string audioFileName = Path.GetFileName(filePath);
                Regex getAudioFileExtensionType = new Regex("[.].*");
                Match audioFileExtensionType = getAudioFileExtensionType.Match(filePath);
                _transcriptorConfig.AudioFileType = audioFileExtensionType.ToString();
                string transcriptionFileName = audioFileName.Replace(_transcriptorConfig.AudioFileType, ".txt");
                //check if transcription has already been made
                if (File.Exists(_transcriptorConfig.TranscriptionOutputDirectory + transcriptionFileName) == true) { continue; }
                //send file to the API and get back a transcript
                Task<List<string>> APITranscription = new Task<List<string>>(() => FakeLongSpeechToTextTranscription(audioFileName));
                APITranscription.Start();
                await APITranscription;
                List<string> transcriptLines = APITranscription.Result;
                //write all lines for that file into a text document
                File.WriteAllLines(_transcriptorConfig.TranscriptionOutputDirectory + transcriptionFileName, transcriptLines);
                transcriptionUpdateString = $"Your completed transcription has been stored here:" + _transcriptorConfig.TranscriptionOutputDirectory + transcriptionFileName;
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
            RecognitionConfig recognitionConfig = new RecognitionConfig()
            {
                AudioChannelCount = _transcriptorConfig.AudioChannelCount,
                EnableSeparateRecognitionPerChannel = _transcriptorConfig.SeperateAudioChannel,
                LanguageCode = _transcriptorConfig.LanguageCode,
                ProfanityFilter = _transcriptorConfig.Profanity,
                EnableWordTimeOffsets = _transcriptorConfig.WordTimeOffset,
                EnableAutomaticPunctuation = _transcriptorConfig.Punctuation,
                DiarizationConfig = new SpeakerDiarizationConfig()
                {
                    EnableSpeakerDiarization = _transcriptorConfig.SpeakerDiarization,
                    MinSpeakerCount = _transcriptorConfig.MinSpeakers,
                    MaxSpeakerCount = _transcriptorConfig.MaxSpeakers
                },
                Model = _transcriptorConfig.ModelType,
                UseEnhanced = _transcriptorConfig.EnhancedSpeaker
            };
            return recognitionConfig;
        }

        //based on code from GoogleCloudPlatform/dotnet-docs-samples/speech/api/Recognize/Recognize.cs
        private List<string> FakeLongSpeechToTextTranscription(string audioFileName)
        {
            int ProgressPercent = 0;
            int fakeTranscriptionCount = 0;
            List<string> transcriptLines = new List<string>();
            while (fakeTranscriptionCount < 20)
            {
                transcriptionUpdateString = $"{DateTime.Now}: File is {ProgressPercent}% complete..." + "\n";
                transcriptionUpdateInt = ProgressPercent;
                Task.Delay(_transcriptorConfig.APIUpdateDelay).Wait();
                fakeTranscriptionCount++;
                ProgressPercent = fakeTranscriptionCount * 5;
            }
            transcriptLines.Add("poo");
            return transcriptLines;
        }
    }
}