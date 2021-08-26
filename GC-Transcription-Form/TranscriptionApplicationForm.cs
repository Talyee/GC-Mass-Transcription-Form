using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GC_Transcription_Form
{
    public partial class TranscriptionApplicationForm : Form
    {
        private PanelTypes currentPanel;
        private ITranscriptionService _transcriptionService;
        private TranscriptorConfig _transcriptorConfig;
        private BackgroundWorker _backgroundWorker;
        private bool transcriptionStart;
        private bool formClosePending;
        private int formUpdateDelay = 100;
        private string transcriptionUpdateString;
        private int transcriptionUpdateInt;

        //The different stages of the form 
        enum PanelTypes
        {
            Initial,
            Settings,
            Processing
        }

        //Initializes the design components and background worker
        public TranscriptionApplicationForm(ITranscriptionService transcriptionService)
        {
            InitializeComponent();
            _transcriptionService = transcriptionService;
            _transcriptorConfig = new TranscriptorConfig();
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.DoWork += BackgroundWorker_Update;
            _backgroundWorker.RunWorkerCompleted += BackgroundWorker_OnCompletion;
            _backgroundWorker.RunWorkerAsync();
            transcriptionStart = false;
        }

        //Method run on background worker thread
        private void BackgroundWorker_Update(object sender, DoWorkEventArgs e)
        {
            while (!_backgroundWorker.CancellationPending)
            {
                Invoke((Action) (() => { InputCheck(); PanelUpdate(); }));
                Thread.Sleep(formUpdateDelay); //update delay
            }
        }

        //Method run on background worker closure
        private void BackgroundWorker_OnCompletion(object sender, RunWorkerCompletedEventArgs e)
        {
            if (formClosePending)
            {
                Close();
            }
            formClosePending = false;
        }

        //Override for form closure to allow correct handling of background worker prior
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_backgroundWorker.IsBusy)
            {
                formClosePending = true;
                _backgroundWorker.CancelAsync();
                e.Cancel = true;
                return;
            }
            base.OnFormClosing(e);
        }

        //(background worker method) Sets the currentPanel property to the correct enum state based on what is being displayed on the form 
        private void PanelUpdate()
        {
            if (currentPanel == PanelTypes.Initial)
            {
                InitialPanel.Visible = true;
                SettingsPanel.Visible = true;
            }
            else if (currentPanel == PanelTypes.Settings)
            {
                InitialPanel.Visible = false;
                SettingsPanel.Visible = true;
            }
            else if (currentPanel == PanelTypes.Processing)
            {
                InitialPanel.Visible = false;
                SettingsPanel.Visible = false;
            }
        }

        //(background worker method) Alters component states based on user input (i.e. next and back buttons)
        private void InputCheck()
        {
            if (currentPanel == PanelTypes.Initial)
            {
                //radio buttons logic
                if (LocalFileStorageRadioButton.Checked)
                {
                    LocalFolderBrowserButton.Enabled = true;
                    LocalFolderBrowserTextBox.Enabled = true;
                }
                else
                {
                    LocalFolderBrowserButton.Enabled = false;
                    LocalFolderBrowserTextBox.Enabled = false;
                    LocalFolderBrowserTextBox.Text = null;

                }
                if (GCBFileStorageRadioButton.Checked)
                {
                    GCBFileStorageTextBox.Enabled = true;
                }
                else
                {
                    GCBFileStorageTextBox.Enabled = false;
                    GCBFileStorageTextBox.Text = null;
                }

                //Panel Input Box Logic
                if (GCCFilePathTextBox.Text.Length > 0 && (GCBFileStorageTextBox.Text.Length > 0 || LocalFolderBrowserTextBox.Text.Length > 0) && SaveTranscriptsFolderTextBox.Text.Length > 0)
                {
                    NextButton.Enabled = true;
                }
                else
                {
                    NextButton.Enabled = false;
                }
                BackButton.Enabled = false;
            }
            else if (currentPanel == PanelTypes.Settings)
            {
                if (CheckBoxSpeakerDiarization.Checked)
                {
                    MaximumSpeakerCount.Enabled = true;
                    MinimumSpeakerCount.Enabled = true;
                }
                else
                {
                    MaximumSpeakerCount.Enabled = false;
                    MinimumSpeakerCount.Enabled = false;
                }
                if (CheckBoxSpeechContext.Checked)
                {
                    SpeechContextFileLocationButton.Enabled = true;
                    SpeechContextFileLocationTextBox.Enabled = true;
                }
                else
                {
                    SpeechContextFileLocationButton.Enabled = false;
                    SpeechContextFileLocationTextBox.Enabled = false;
                    SpeechContextFileLocationTextBox.Text = null;
                }
                if (CheckBoxSpeechContext.Checked)
                {
                    if (SpeechContextFileLocationTextBox.Text.Length > 0)
                    {
                        NextButton.Enabled = true;
                    }
                    else
                    {
                        NextButton.Enabled = false;
                    }
                }
                else
                {
                    NextButton.Enabled = true;
                }
                if (AudioModelTypeSelection.Text.Length > 0)
                {
                    NextButton.Enabled = true;
                }
                else
                {
                    NextButton.Enabled = false;
                }
                if (LanguageCodeSelection.Text.Length > 0)
                {
                    NextButton.Enabled = true;
                }
                else
                {
                    NextButton.Enabled = false;
                }
                BackButton.Enabled = true;
            }
            else if (currentPanel == PanelTypes.Processing)
            {
                NextButton.Enabled = false;
                BackButton.Enabled = false;
                if (!transcriptionStart)
                {
                    transcriptionStart = true;
                    transcriptionUpdateString = "";
                    transcriptionUpdateInt = 0;
                    _transcriptorConfig.APIUpdateDelay = 1000; //moved the magic number up a layer aha (SORT THIS OUT)
                    _transcriptionService.BeginTranscription(_transcriptorConfig);
                }
                else
                {
                    string transcriptionNewUpdateString = _transcriptionService.GetTranscriptionProgressString();
                    transcriptionUpdateInt = _transcriptionService.GetTranscriptionProgressInt();
                    if (transcriptionUpdateString != transcriptionNewUpdateString)
                    {
                        OutputTextBox.Text += transcriptionNewUpdateString;
                        transcriptionUpdateString = transcriptionNewUpdateString;
                        UpdateProgressBar();
                    }
                }
            }
        }

        private void UpdateProgressBar()
        {
            ProgressBar.Value = transcriptionUpdateInt;
        }

        //Gather all of the required user input from the form to be processed
        private void GetUserInfo()
        {
            _transcriptorConfig.GoogleCloudCredentialsPath = GCCFilePathTextBox.Text;
            if (LocalFolderBrowserTextBox.Enabled)
            {
                _transcriptorConfig.AudioFileDirectory = LocalFolderBrowserTextBox.Text;
            }
            else
            {
                _transcriptorConfig.GoogleCloudAudioBucketUrl = GCBFileStorageTextBox.Text;
            }
            _transcriptorConfig.TranscriptionOutputDirectory = SaveTranscriptsFolderTextBox.Text;
            _transcriptorConfig.EnhancedSpeaker = CheckBoxEnhanced.Checked;
            _transcriptorConfig.Punctuation = CheckBoxPunctuation.Checked;
            _transcriptorConfig.Profanity = CheckBoxProfanity.Checked;
            _transcriptorConfig.WordTimeOffset = CheckBoxWordTime.Checked;
            _transcriptorConfig.SeperateAudioChannel = CheckBoxAudioChannelRec.Checked;
            _transcriptorConfig.AudioChannelCount = Decimal.ToInt32(AudioChannelCount.Value);
            _transcriptorConfig.ModelType = AudioModelTypeSelection.Text;
            _transcriptorConfig.LanguageCode = LanguageCodeSelection.Text;
            _transcriptorConfig.SpeakerDiarization = CheckBoxSpeakerDiarization.Checked;
            if (_transcriptorConfig.SpeakerDiarization)
            {
                _transcriptorConfig.MinSpeakers = Decimal.ToInt32(MinimumSpeakerCount.Value);
                _transcriptorConfig.MaxSpeakers = Decimal.ToInt32(MaximumSpeakerCount.Value);
            }
            _transcriptorConfig.SpeechContext = CheckBoxSpeechContext.Checked;
            if (_transcriptorConfig.SpeechContext)
            {
                _transcriptorConfig.SpeechContextFilePath = SpeechContextFileLocationTextBox.Text;
            }
        }

        //Check that all of the user info provided is what is needed (e.g. file paths work)
        /// <summary> returns true if the check is passed and false if the check is failed </summary>
        private bool UserInfoCheck()
        {
            try
            {
                File.Exists(_transcriptorConfig.GoogleCloudCredentialsPath);
                Directory.Exists(_transcriptorConfig.TranscriptionOutputDirectory);
                if (_transcriptorConfig.AudioFileDirectory != null)
                {
                    string[] audioFiles = Directory.GetFiles(_transcriptorConfig.AudioFileDirectory);
                    if (audioFiles.Length < 1)
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                ErrorAlert(e);
                return false;
            }
        }

        private void ErrorAlert(Exception e)
        {
            MessageBox.Show($"Description: {e.Message}", $"Error Type {e.GetType()}");
        }

        //Give the dialogue for the user to review the info provided
        private void ProcessDialogueCheck()
        {
            string dialogueBoxInfo = $"Google Cloud Credentials File Path:\n {_transcriptorConfig.GoogleCloudCredentialsPath}\n\n";
            if(_transcriptorConfig.AudioFileDirectory != null)
            {
                dialogueBoxInfo += $"Audio File Path:\n {_transcriptorConfig.AudioFileDirectory}\n\n";
            }
            else if (_transcriptorConfig.GoogleCloudAudioBucketUrl != null)
            {
                dialogueBoxInfo += $"Google Cloud Bucket:\n {_transcriptorConfig.GoogleCloudAudioBucketUrl}\n\n";
            }
            dialogueBoxInfo += $"Transcription File Path:\n {_transcriptorConfig.TranscriptionOutputDirectory}\n\n" +
                $"Enhanced Speaker:\n {_transcriptorConfig.EnhancedSpeaker}\n\n" +
                $"Punctuation:\n {_transcriptorConfig.Punctuation}\n\n" +
                $"Profanity:\n {_transcriptorConfig.Profanity}\n\n" +
                $"Word Time Offset:\n {_transcriptorConfig.WordTimeOffset}\n\n" +
                $"Seperate Audio Channel:\n {_transcriptorConfig.SeperateAudioChannel}\n\n" +
                $"Audio Channel Count:\n {_transcriptorConfig.AudioChannelCount}\n\n" +
                $"ModelType:\n {_transcriptorConfig.ModelType}\n\n" +
                $"Language Code:\n {_transcriptorConfig.LanguageCode}\n\n" +
                $"Speaker Diarization:\n {_transcriptorConfig.SpeakerDiarization}\n\n" +
                $"Speech Context:\n {_transcriptorConfig.SpeechContext}\n\n";

            DialogResult confirmResult = MessageBox.Show(dialogueBoxInfo, "Are you ready to begin transcribing with these settings?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                currentPanel += 1;
            }
        }

        /// <param name="Dialogue Box Type">
        /// File = 0, Folder = 1
        /// </param>
        private string GetStringDialogueBox(int dialogueType)
        {
            if (dialogueType == 0)//File
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();
                return openFileDialog.FileName;
            }
            if (dialogueType == 1)//Folder
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowDialog();
                return folderBrowserDialog.SelectedPath;
            }
            return null;
        }

        #region Event Methods

        //Functions the same as the standard form close button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        //Next enum panel
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (currentPanel == PanelTypes.Settings)
            {
                GetUserInfo();
                if (UserInfoCheck())
                {
                    ProcessDialogueCheck();
                }
            }
            else
            {
                currentPanel += 1;
            }
        }

        //Previous enum panel
        private void BackButton_Click(object sender, EventArgs e)
        {
            currentPanel -= 1;
        }

        private void GCCFileBrowserButton_Click(object sender, EventArgs e)
        {
            GCCFilePathTextBox.Text = GetStringDialogueBox(0);
        }

        private void LocalFolderBrowserButton_Click(object sender, EventArgs e)
        {
            LocalFolderBrowserTextBox.Text = GetStringDialogueBox(1);
        }

        private void SaveTranscriptsFolderButton_Click(object sender, EventArgs e)
        {
            SaveTranscriptsFolderTextBox.Text = GetStringDialogueBox(1);
        }

        private void SpeechContextFileLocationButton_Click(object sender, EventArgs e)
        {
            SpeechContextFileLocationTextBox.Text = GetStringDialogueBox(0);
        }

        #endregion
    }
}