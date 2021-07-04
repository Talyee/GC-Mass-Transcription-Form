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
    public partial class MainForm : Form
    {
        private PanelTypes currentPanel;
        private ITranscriptionService _transcriptionService;
        private TranscriptionConfig _transcriptionConfig;
        private BackgroundWorker _backgroundWorker;
        private bool formClosePending;

        //The different stages of the form 
        enum PanelTypes
        {
            Initial,
            Settings,
            Processing
        }

        //Initializes the design components and background worker
        public MainForm(ITranscriptionService transcriptionService)
        {
            InitializeComponent();
            _transcriptionService = transcriptionService;
            _transcriptionConfig = new TranscriptionConfig();
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.DoWork += BackgroundWorker_Update;
            _backgroundWorker.RunWorkerCompleted += BackgroundWorker_OnCompletion;
            _backgroundWorker.RunWorkerAsync();
        }

        //Method run on background worker thread
        private void BackgroundWorker_Update(object sender, DoWorkEventArgs e)
        {
            while (!_backgroundWorker.CancellationPending)
            {
                Invoke((Action) (() => { InputCheck(); PanelUpdate(); }));
                Thread.Sleep(100); //update delay
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
            else
            {
                Console.WriteLine("Uh Oh bad issue with panel display");
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
                }
                if (GCBFileStorageRadioButton.Checked)
                {
                    GCBFileStorageTextBox.Enabled = true;
                }
                else
                {
                    GCBFileStorageTextBox.Enabled = false;
                }

                //Panel Input Box Logic
                if (GCCFilePathTextBox.Text.ToLower().Contains(".json") && (LocalFileStorageRadioButton.Checked == true || GCBFileStorageRadioButton.Checked == true))
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
                }
                NextButton.Enabled = true;
                BackButton.Enabled = true;
            }
            else if (currentPanel == PanelTypes.Processing)
            {
                NextButton.Enabled = false;
                BackButton.Enabled = true;
            }
        }

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
                UserInfoCheck();
                ProcessDialogueCheck();
            }
            else
            {
                currentPanel += 1;
            }
        }

        //Gather all of the required user input from the form to be processed
        private void GetUserInfo()
        {
            _transcriptionConfig.GoogleCloudCredentialsPath = GCCFilePathTextBox.Text;
            if (LocalFolderBrowserTextBox.Enabled)
            {
                _transcriptionConfig.AudioFileDirectory = LocalFolderBrowserTextBox.Text;
            }
            else
            {
                _transcriptionConfig.GoogleCloudAudioBucketUrl = GCBFileStorageTextBox.Text;
            }
            _transcriptionConfig.TranscriptionOutputDirectory = SaveTranscriptsFolderTextBox.Text;
            _transcriptionConfig.EnhancedSpeaker = CheckBoxEnhanced.Checked;
            _transcriptionConfig.Punctuation = CheckBoxPunctuation.Checked;
            _transcriptionConfig.Profanity = CheckBoxProfanity.Checked;
            _transcriptionConfig.WordTimeOffset = CheckBoxWordTime.Checked;
            _transcriptionConfig.SeperateAudioChannel = CheckBoxAudioChannelRec.Checked;
            _transcriptionConfig.AudioChannelCount = AudioChannelCount.Value;
            _transcriptionConfig.ModelType = AudioModelTypeSelection.Text;
            _transcriptionConfig.LanguageCode = LanguageCodeSelection.Text;
            _transcriptionConfig.SpeakerDiarization = CheckBoxSpeakerDiarization.Checked;
            if (_transcriptionConfig.SpeakerDiarization)
            {
                _transcriptionConfig.MinSpeakers = MinimumSpeakerCount.Value;
                _transcriptionConfig.MaxSpeakers = MaximumSpeakerCount.Value;
            }
            _transcriptionConfig.SpeechContext = CheckBoxSpeechContext.Checked;
            if (_transcriptionConfig.SpeechContext)
            {
                _transcriptionConfig.SpeechContextFilePath = SpeechContextFileLocationTextBox.Text;
            }
        }

        //Check that all of the user info provided is what is needed (e.g. file paths work)
        private void UserInfoCheck()
        {
            DirectoryInfo audioFolderDirectory = new DirectoryInfo(_transcriptionConfig.AudioFileDirectory);
            FileInfo[] audioFiles = audioFolderDirectory.GetFiles();
            if (audioFiles.Length < 1)
            {
                //error
            }
        }

        //Give the dialogue for the user to review the info provided
        private void ProcessDialogueCheck()
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you are ready to begin transcribing with these settings?",
                $"Google Cloud Credentials File Path: {_transcriptionConfig.GoogleCloudAudioBucketUrl}\n" +
                $"Audio File Path: {_transcriptionConfig.AudioFileDirectory}",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
            }
            else
            {
                // If 'No', do something here.
            }
        }

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

        //Previous enum panel
        private void BackButton_Click(object sender, EventArgs e)
        {
            currentPanel -= 1;
        }

        /// <param name="Dialogue Box Type">
        /// File = 0, Folder = 1
        /// </param>


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