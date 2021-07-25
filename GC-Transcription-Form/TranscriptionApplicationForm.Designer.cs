
namespace GC_Transcription_Form
{
    partial class TranscriptionApplicationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelInputBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InitialPanel = new System.Windows.Forms.Panel();
            this.InitialPanelLabel2 = new System.Windows.Forms.Label();
            this.SaveTranscriptsFolderButton = new System.Windows.Forms.Button();
            this.SaveTranscriptsFolderTextBox = new System.Windows.Forms.TextBox();
            this.LocalFolderBrowserButton = new System.Windows.Forms.Button();
            this.LocalFolderBrowserTextBox = new System.Windows.Forms.TextBox();
            this.GCBFileStorageTextBox = new System.Windows.Forms.TextBox();
            this.LocalFileStorageRadioButton = new System.Windows.Forms.RadioButton();
            this.InitialPanelLabel3 = new System.Windows.Forms.Label();
            this.GCBFileStorageRadioButton = new System.Windows.Forms.RadioButton();
            this.GCCFilePathTextBox = new System.Windows.Forms.TextBox();
            this.GCCFileBrowserButton = new System.Windows.Forms.Button();
            this.InitialPanelLabel1 = new System.Windows.Forms.Label();
            this.ProcessingPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SettingsLabel2 = new System.Windows.Forms.Label();
            this.AudioChannelCount = new System.Windows.Forms.NumericUpDown();
            this.SettingsLabel1 = new System.Windows.Forms.Label();
            this.SpeechContextGroupBox = new System.Windows.Forms.GroupBox();
            this.SettingsLabel7 = new System.Windows.Forms.Label();
            this.SpeechContextFileLocationTextBox = new System.Windows.Forms.TextBox();
            this.SpeechContextFileLocationButton = new System.Windows.Forms.Button();
            this.CheckBoxSpeechContext = new System.Windows.Forms.CheckBox();
            this.DiarizationGroupBox = new System.Windows.Forms.GroupBox();
            this.SettingsLabel5 = new System.Windows.Forms.Label();
            this.SettingsLabel6 = new System.Windows.Forms.Label();
            this.MaximumSpeakerCount = new System.Windows.Forms.NumericUpDown();
            this.MinimumSpeakerCount = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxSpeakerDiarization = new System.Windows.Forms.CheckBox();
            this.SettingsLabel4 = new System.Windows.Forms.Label();
            this.LanguageCodeSelection = new System.Windows.Forms.ComboBox();
            this.SettingsLabel3 = new System.Windows.Forms.Label();
            this.AudioModelTypeSelection = new System.Windows.Forms.ComboBox();
            this.CheckBoxEnhanced = new System.Windows.Forms.CheckBox();
            this.CheckBoxPunctuation = new System.Windows.Forms.CheckBox();
            this.CheckBoxWordTime = new System.Windows.Forms.CheckBox();
            this.CheckBoxProfanity = new System.Windows.Forms.CheckBox();
            this.CheckBoxAudioChannelRec = new System.Windows.Forms.CheckBox();
            this.PanelInputBox.SuspendLayout();
            this.InitialPanel.SuspendLayout();
            this.ProcessingPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AudioChannelCount)).BeginInit();
            this.SpeechContextGroupBox.SuspendLayout();
            this.DiarizationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumSpeakerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumSpeakerCount)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(572, 22);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(396, 22);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(477, 22);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next >";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(17, 314);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(630, 23);
            this.ProgressBar.TabIndex = 3;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.OutputTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutputTextBox.Enabled = false;
            this.OutputTextBox.Location = new System.Drawing.Point(17, 21);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.OutputTextBox.Size = new System.Drawing.Size(630, 287);
            this.OutputTextBox.TabIndex = 4;
            this.OutputTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // PanelInputBox
            // 
            this.PanelInputBox.Controls.Add(this.BackButton);
            this.PanelInputBox.Controls.Add(this.CancelButton);
            this.PanelInputBox.Controls.Add(this.label2);
            this.PanelInputBox.Controls.Add(this.NextButton);
            this.PanelInputBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelInputBox.Location = new System.Drawing.Point(-5, 334);
            this.PanelInputBox.Name = "PanelInputBox";
            this.PanelInputBox.Size = new System.Drawing.Size(663, 80);
            this.PanelInputBox.TabIndex = 7;
            this.PanelInputBox.TabStop = false;
            this.PanelInputBox.Text = "GC Mass Transcriptor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thank you for using this software!";
            // 
            // InitialPanel
            // 
            this.InitialPanel.Controls.Add(this.InitialPanelLabel2);
            this.InitialPanel.Controls.Add(this.SaveTranscriptsFolderButton);
            this.InitialPanel.Controls.Add(this.SaveTranscriptsFolderTextBox);
            this.InitialPanel.Controls.Add(this.LocalFolderBrowserButton);
            this.InitialPanel.Controls.Add(this.LocalFolderBrowserTextBox);
            this.InitialPanel.Controls.Add(this.GCBFileStorageTextBox);
            this.InitialPanel.Controls.Add(this.LocalFileStorageRadioButton);
            this.InitialPanel.Controls.Add(this.InitialPanelLabel3);
            this.InitialPanel.Controls.Add(this.GCBFileStorageRadioButton);
            this.InitialPanel.Controls.Add(this.GCCFilePathTextBox);
            this.InitialPanel.Controls.Add(this.GCCFileBrowserButton);
            this.InitialPanel.Controls.Add(this.InitialPanelLabel1);
            this.InitialPanel.Location = new System.Drawing.Point(0, 0);
            this.InitialPanel.Name = "InitialPanel";
            this.InitialPanel.Size = new System.Drawing.Size(663, 344);
            this.InitialPanel.TabIndex = 5;
            // 
            // InitialPanelLabel2
            // 
            this.InitialPanelLabel2.AutoSize = true;
            this.InitialPanelLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InitialPanelLabel2.Location = new System.Drawing.Point(52, 134);
            this.InitialPanelLabel2.Name = "InitialPanelLabel2";
            this.InitialPanelLabel2.Size = new System.Drawing.Size(254, 21);
            this.InitialPanelLabel2.TabIndex = 14;
            this.InitialPanelLabel2.Text = "Where are your audio files located?";
            // 
            // SaveTranscriptsFolderButton
            // 
            this.SaveTranscriptsFolderButton.Location = new System.Drawing.Point(542, 284);
            this.SaveTranscriptsFolderButton.Name = "SaveTranscriptsFolderButton";
            this.SaveTranscriptsFolderButton.Size = new System.Drawing.Size(75, 23);
            this.SaveTranscriptsFolderButton.TabIndex = 13;
            this.SaveTranscriptsFolderButton.Text = "Browse...";
            this.SaveTranscriptsFolderButton.UseVisualStyleBackColor = true;
            this.SaveTranscriptsFolderButton.Click += new System.EventHandler(this.SaveTranscriptsFolderButton_Click);
            // 
            // SaveTranscriptsFolderTextBox
            // 
            this.SaveTranscriptsFolderTextBox.Location = new System.Drawing.Point(52, 284);
            this.SaveTranscriptsFolderTextBox.Name = "SaveTranscriptsFolderTextBox";
            this.SaveTranscriptsFolderTextBox.Size = new System.Drawing.Size(484, 23);
            this.SaveTranscriptsFolderTextBox.TabIndex = 12;
            // 
            // LocalFolderBrowserButton
            // 
            this.LocalFolderBrowserButton.Location = new System.Drawing.Point(542, 162);
            this.LocalFolderBrowserButton.Name = "LocalFolderBrowserButton";
            this.LocalFolderBrowserButton.Size = new System.Drawing.Size(75, 23);
            this.LocalFolderBrowserButton.TabIndex = 10;
            this.LocalFolderBrowserButton.Text = "Browse...";
            this.LocalFolderBrowserButton.UseVisualStyleBackColor = true;
            this.LocalFolderBrowserButton.Click += new System.EventHandler(this.LocalFolderBrowserButton_Click);
            // 
            // LocalFolderBrowserTextBox
            // 
            this.LocalFolderBrowserTextBox.Location = new System.Drawing.Point(195, 162);
            this.LocalFolderBrowserTextBox.Name = "LocalFolderBrowserTextBox";
            this.LocalFolderBrowserTextBox.Size = new System.Drawing.Size(341, 23);
            this.LocalFolderBrowserTextBox.TabIndex = 8;
            // 
            // GCBFileStorageTextBox
            // 
            this.GCBFileStorageTextBox.Location = new System.Drawing.Point(195, 197);
            this.GCBFileStorageTextBox.Name = "GCBFileStorageTextBox";
            this.GCBFileStorageTextBox.Size = new System.Drawing.Size(422, 23);
            this.GCBFileStorageTextBox.TabIndex = 7;
            // 
            // LocalFileStorageRadioButton
            // 
            this.LocalFileStorageRadioButton.AutoSize = true;
            this.LocalFileStorageRadioButton.Location = new System.Drawing.Point(52, 164);
            this.LocalFileStorageRadioButton.Name = "LocalFileStorageRadioButton";
            this.LocalFileStorageRadioButton.Size = new System.Drawing.Size(122, 19);
            this.LocalFileStorageRadioButton.TabIndex = 6;
            this.LocalFileStorageRadioButton.TabStop = true;
            this.LocalFileStorageRadioButton.Text = "My Local Machine";
            this.LocalFileStorageRadioButton.UseVisualStyleBackColor = true;
            // 
            // InitialPanelLabel3
            // 
            this.InitialPanelLabel3.AutoSize = true;
            this.InitialPanelLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InitialPanelLabel3.Location = new System.Drawing.Point(52, 254);
            this.InitialPanelLabel3.Name = "InitialPanelLabel3";
            this.InitialPanelLabel3.Size = new System.Drawing.Size(455, 21);
            this.InitialPanelLabel3.TabIndex = 5;
            this.InitialPanelLabel3.Text = "Where would you like your transcripted documents to be saved?";
            // 
            // GCBFileStorageRadioButton
            // 
            this.GCBFileStorageRadioButton.AutoSize = true;
            this.GCBFileStorageRadioButton.Location = new System.Drawing.Point(52, 198);
            this.GCBFileStorageRadioButton.Name = "GCBFileStorageRadioButton";
            this.GCBFileStorageRadioButton.Size = new System.Drawing.Size(137, 19);
            this.GCBFileStorageRadioButton.TabIndex = 4;
            this.GCBFileStorageRadioButton.TabStop = true;
            this.GCBFileStorageRadioButton.Text = "Google Cloud Bucket";
            this.GCBFileStorageRadioButton.UseVisualStyleBackColor = true;
            // 
            // GCCFilePathTextBox
            // 
            this.GCCFilePathTextBox.Location = new System.Drawing.Point(52, 72);
            this.GCCFilePathTextBox.Name = "GCCFilePathTextBox";
            this.GCCFilePathTextBox.Size = new System.Drawing.Size(484, 23);
            this.GCCFilePathTextBox.TabIndex = 3;
            // 
            // GCCFileBrowserButton
            // 
            this.GCCFileBrowserButton.Location = new System.Drawing.Point(542, 72);
            this.GCCFileBrowserButton.Name = "GCCFileBrowserButton";
            this.GCCFileBrowserButton.Size = new System.Drawing.Size(75, 23);
            this.GCCFileBrowserButton.TabIndex = 2;
            this.GCCFileBrowserButton.Text = "Browse...";
            this.GCCFileBrowserButton.UseVisualStyleBackColor = true;
            this.GCCFileBrowserButton.Click += new System.EventHandler(this.GCCFileBrowserButton_Click);
            // 
            // InitialPanelLabel1
            // 
            this.InitialPanelLabel1.AutoSize = true;
            this.InitialPanelLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InitialPanelLabel1.Location = new System.Drawing.Point(52, 42);
            this.InitialPanelLabel1.Name = "InitialPanelLabel1";
            this.InitialPanelLabel1.Size = new System.Drawing.Size(464, 21);
            this.InitialPanelLabel1.TabIndex = 1;
            this.InitialPanelLabel1.Text = "Please select the path to your Google Cloud Credentials JSON file:";
            // 
            // ProcessingPanel
            // 
            this.ProcessingPanel.Controls.Add(this.SettingsPanel);
            this.ProcessingPanel.Controls.Add(this.OutputTextBox);
            this.ProcessingPanel.Controls.Add(this.ProgressBar);
            this.ProcessingPanel.Location = new System.Drawing.Point(-5, -9);
            this.ProcessingPanel.Name = "ProcessingPanel";
            this.ProcessingPanel.Size = new System.Drawing.Size(663, 351);
            this.ProcessingPanel.TabIndex = 8;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.InitialPanel);
            this.SettingsPanel.Controls.Add(this.SettingsLabel2);
            this.SettingsPanel.Controls.Add(this.AudioChannelCount);
            this.SettingsPanel.Controls.Add(this.SettingsLabel1);
            this.SettingsPanel.Controls.Add(this.SpeechContextGroupBox);
            this.SettingsPanel.Controls.Add(this.DiarizationGroupBox);
            this.SettingsPanel.Controls.Add(this.SettingsLabel4);
            this.SettingsPanel.Controls.Add(this.LanguageCodeSelection);
            this.SettingsPanel.Controls.Add(this.SettingsLabel3);
            this.SettingsPanel.Controls.Add(this.AudioModelTypeSelection);
            this.SettingsPanel.Controls.Add(this.CheckBoxEnhanced);
            this.SettingsPanel.Controls.Add(this.CheckBoxPunctuation);
            this.SettingsPanel.Controls.Add(this.CheckBoxWordTime);
            this.SettingsPanel.Controls.Add(this.CheckBoxProfanity);
            this.SettingsPanel.Controls.Add(this.CheckBoxAudioChannelRec);
            this.SettingsPanel.Location = new System.Drawing.Point(1, 7);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(663, 352);
            this.SettingsPanel.TabIndex = 7;
            // 
            // SettingsLabel2
            // 
            this.SettingsLabel2.AutoSize = true;
            this.SettingsLabel2.Location = new System.Drawing.Point(34, 188);
            this.SettingsLabel2.Name = "SettingsLabel2";
            this.SettingsLabel2.Size = new System.Drawing.Size(122, 15);
            this.SettingsLabel2.TabIndex = 13;
            this.SettingsLabel2.Text = "Audio Channel Count";
            // 
            // AudioChannelCount
            // 
            this.AudioChannelCount.Location = new System.Drawing.Point(34, 204);
            this.AudioChannelCount.Name = "AudioChannelCount";
            this.AudioChannelCount.Size = new System.Drawing.Size(186, 23);
            this.AudioChannelCount.TabIndex = 12;
            this.AudioChannelCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingsLabel1
            // 
            this.SettingsLabel1.AutoSize = true;
            this.SettingsLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsLabel1.Location = new System.Drawing.Point(34, 14);
            this.SettingsLabel1.Name = "SettingsLabel1";
            this.SettingsLabel1.Size = new System.Drawing.Size(245, 21);
            this.SettingsLabel1.TabIndex = 11;
            this.SettingsLabel1.Text = "Please Select The Desired Settings";
            // 
            // SpeechContextGroupBox
            // 
            this.SpeechContextGroupBox.Controls.Add(this.SettingsLabel7);
            this.SpeechContextGroupBox.Controls.Add(this.SpeechContextFileLocationTextBox);
            this.SpeechContextGroupBox.Controls.Add(this.SpeechContextFileLocationButton);
            this.SpeechContextGroupBox.Controls.Add(this.CheckBoxSpeechContext);
            this.SpeechContextGroupBox.Location = new System.Drawing.Point(311, 188);
            this.SpeechContextGroupBox.Name = "SpeechContextGroupBox";
            this.SpeechContextGroupBox.Size = new System.Drawing.Size(352, 142);
            this.SpeechContextGroupBox.TabIndex = 10;
            this.SpeechContextGroupBox.TabStop = false;
            this.SpeechContextGroupBox.Text = "Speech Context";
            // 
            // SettingsLabel7
            // 
            this.SettingsLabel7.AutoSize = true;
            this.SettingsLabel7.Location = new System.Drawing.Point(27, 66);
            this.SettingsLabel7.Name = "SettingsLabel7";
            this.SettingsLabel7.Size = new System.Drawing.Size(184, 15);
            this.SettingsLabel7.TabIndex = 3;
            this.SettingsLabel7.Text = "Speech Context Text File Location";
            // 
            // SpeechContextFileLocationTextBox
            // 
            this.SpeechContextFileLocationTextBox.Location = new System.Drawing.Point(27, 84);
            this.SpeechContextFileLocationTextBox.Name = "SpeechContextFileLocationTextBox";
            this.SpeechContextFileLocationTextBox.Size = new System.Drawing.Size(214, 23);
            this.SpeechContextFileLocationTextBox.TabIndex = 2;
            // 
            // SpeechContextFileLocationButton
            // 
            this.SpeechContextFileLocationButton.Location = new System.Drawing.Point(245, 84);
            this.SpeechContextFileLocationButton.Name = "SpeechContextFileLocationButton";
            this.SpeechContextFileLocationButton.Size = new System.Drawing.Size(75, 23);
            this.SpeechContextFileLocationButton.TabIndex = 1;
            this.SpeechContextFileLocationButton.Text = "Browse...";
            this.SpeechContextFileLocationButton.UseVisualStyleBackColor = true;
            this.SpeechContextFileLocationButton.Click += new System.EventHandler(this.SpeechContextFileLocationButton_Click);
            // 
            // CheckBoxSpeechContext
            // 
            this.CheckBoxSpeechContext.AutoSize = true;
            this.CheckBoxSpeechContext.Location = new System.Drawing.Point(6, 22);
            this.CheckBoxSpeechContext.Name = "CheckBoxSpeechContext";
            this.CheckBoxSpeechContext.Size = new System.Drawing.Size(147, 19);
            this.CheckBoxSpeechContext.TabIndex = 0;
            this.CheckBoxSpeechContext.Text = "Enable Speech Context";
            this.CheckBoxSpeechContext.UseVisualStyleBackColor = true;
            // 
            // DiarizationGroupBox
            // 
            this.DiarizationGroupBox.Controls.Add(this.SettingsLabel5);
            this.DiarizationGroupBox.Controls.Add(this.SettingsLabel6);
            this.DiarizationGroupBox.Controls.Add(this.MaximumSpeakerCount);
            this.DiarizationGroupBox.Controls.Add(this.MinimumSpeakerCount);
            this.DiarizationGroupBox.Controls.Add(this.CheckBoxSpeakerDiarization);
            this.DiarizationGroupBox.Location = new System.Drawing.Point(311, 42);
            this.DiarizationGroupBox.Name = "DiarizationGroupBox";
            this.DiarizationGroupBox.Size = new System.Drawing.Size(352, 135);
            this.DiarizationGroupBox.TabIndex = 9;
            this.DiarizationGroupBox.TabStop = false;
            this.DiarizationGroupBox.Text = "Diarization";
            // 
            // SettingsLabel5
            // 
            this.SettingsLabel5.AutoSize = true;
            this.SettingsLabel5.Location = new System.Drawing.Point(27, 66);
            this.SettingsLabel5.Name = "SettingsLabel5";
            this.SettingsLabel5.Size = new System.Drawing.Size(109, 15);
            this.SettingsLabel5.TabIndex = 3;
            this.SettingsLabel5.Text = "Minimum Speakers";
            // 
            // SettingsLabel6
            // 
            this.SettingsLabel6.AutoSize = true;
            this.SettingsLabel6.Location = new System.Drawing.Point(200, 66);
            this.SettingsLabel6.Name = "SettingsLabel6";
            this.SettingsLabel6.Size = new System.Drawing.Size(111, 15);
            this.SettingsLabel6.TabIndex = 3;
            this.SettingsLabel6.Text = "Maximum Speakers";
            // 
            // MaximumSpeakerCount
            // 
            this.MaximumSpeakerCount.Location = new System.Drawing.Point(200, 84);
            this.MaximumSpeakerCount.Name = "MaximumSpeakerCount";
            this.MaximumSpeakerCount.Size = new System.Drawing.Size(120, 23);
            this.MaximumSpeakerCount.TabIndex = 2;
            // 
            // MinimumSpeakerCount
            // 
            this.MinimumSpeakerCount.Location = new System.Drawing.Point(27, 84);
            this.MinimumSpeakerCount.Name = "MinimumSpeakerCount";
            this.MinimumSpeakerCount.Size = new System.Drawing.Size(120, 23);
            this.MinimumSpeakerCount.TabIndex = 1;
            // 
            // CheckBoxSpeakerDiarization
            // 
            this.CheckBoxSpeakerDiarization.AutoSize = true;
            this.CheckBoxSpeakerDiarization.Location = new System.Drawing.Point(6, 22);
            this.CheckBoxSpeakerDiarization.Name = "CheckBoxSpeakerDiarization";
            this.CheckBoxSpeakerDiarization.Size = new System.Drawing.Size(164, 19);
            this.CheckBoxSpeakerDiarization.TabIndex = 0;
            this.CheckBoxSpeakerDiarization.Text = "Enable Speaker Diarization";
            this.CheckBoxSpeakerDiarization.UseVisualStyleBackColor = true;
            // 
            // SettingsLabel4
            // 
            this.SettingsLabel4.AutoSize = true;
            this.SettingsLabel4.Location = new System.Drawing.Point(34, 281);
            this.SettingsLabel4.Name = "SettingsLabel4";
            this.SettingsLabel4.Size = new System.Drawing.Size(90, 15);
            this.SettingsLabel4.TabIndex = 8;
            this.SettingsLabel4.Text = "Language Code";
            // 
            // LanguageCodeSelection
            // 
            this.LanguageCodeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageCodeSelection.FormattingEnabled = true;
            this.LanguageCodeSelection.Items.AddRange(new object[] {
            "af-ZA",
            "sq-AL",
            "am-ET",
            "ar-DZ",
            "ar-BH",
            "ar-EG",
            "ar-IQ",
            "ar-IL",
            "ar-JO",
            "ar-KW",
            "ar-LB",
            "ar-MA",
            "ar-OM",
            "ar-QA",
            "ar-SA",
            "ar-PS",
            "ar-TN",
            "ar-AE",
            "ar-YE",
            "hy-AM",
            "az-AZ",
            "eu-ES",
            "bn-BD",
            "bn-IN",
            "bs-BA",
            "bg-BG",
            "my-MM",
            "ca-ES",
            "ue-Ha",
            "nt-HK",
            "mn-Ha",
            "ns-CN",
            "zh-TW",
            "nt-TW",
            "hr-HR",
            "cs-CZ",
            "da-DK",
            "nl-BE",
            "nl-NL",
            "en-AU",
            "en-CA",
            "en-GH",
            "en-HK",
            "en-IN",
            "en-IE",
            "en-KE",
            "en-NZ",
            "en-NG",
            "en-PK",
            "en-PH",
            "en-SG",
            "en-ZA",
            "en-TZ",
            "en-GB",
            "en-US",
            "et-EE",
            "il-PH",
            "fi-FI",
            "fr-BE",
            "fr-CA",
            "fr-FR",
            "fr-CH",
            "gl-ES",
            "ka-GE",
            "de-AT",
            "de-DE",
            "de-CH",
            "el-GR",
            "gu-IN",
            "iw-IL",
            "hi-IN",
            "hu-HU",
            "is-IS",
            "id-ID",
            "it-IT",
            "it-CH",
            "ja-JP",
            "jv-ID",
            "kn-IN",
            "kk-KZ",
            "km-KH",
            "ko-KR",
            "lo-LA",
            "lv-LV",
            "lt-LT",
            "mk-MK",
            "ms-MY",
            "ml-IN",
            "mr-IN",
            "mn-MN",
            "ne-NP",
            "no-NO",
            "fa-IR",
            "pl-PL",
            "pt-BR",
            "pt-PT",
            "pa-Gu",
            "ru-IN",
            "ro-RO",
            "ru-RU",
            "sr-RS",
            "si-LK",
            "sk-SK",
            "sl-SI",
            "es-AR",
            "es-BO",
            "es-CL",
            "es-CO",
            "es-CR",
            "es-DO",
            "es-EC",
            "es-SV",
            "es-GT",
            "es-HN",
            "es-MX",
            "es-NI",
            "es-PA",
            "es-PY",
            "es-PE",
            "es-PR",
            "es-ES",
            "es-US",
            "es-UY",
            "es-VE",
            "su-ID",
            "sw-KE",
            "sw-TZ",
            "sv-SE",
            "ta-IN",
            "ta-MY",
            "ta-SG",
            "ta-LK",
            "te-IN",
            "th-TH",
            "tr-TR",
            "uk-UA",
            "ur-IN",
            "ur-PK",
            "uz-UZ",
            "vi-VN",
            "zu-Z"});
            this.LanguageCodeSelection.Location = new System.Drawing.Point(34, 299);
            this.LanguageCodeSelection.Name = "LanguageCodeSelection";
            this.LanguageCodeSelection.Size = new System.Drawing.Size(186, 23);
            this.LanguageCodeSelection.TabIndex = 7;
            // 
            // SettingsLabel3
            // 
            this.SettingsLabel3.AutoSize = true;
            this.SettingsLabel3.Location = new System.Drawing.Point(34, 234);
            this.SettingsLabel3.Name = "SettingsLabel3";
            this.SettingsLabel3.Size = new System.Drawing.Size(68, 15);
            this.SettingsLabel3.TabIndex = 6;
            this.SettingsLabel3.Text = "Model Type";
            // 
            // AudioModelTypeSelection
            // 
            this.AudioModelTypeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AudioModelTypeSelection.FormattingEnabled = true;
            this.AudioModelTypeSelection.Items.AddRange(new object[] {
            "Default",
            "Phone Call",
            "Video",
            "Voice Commands"});
            this.AudioModelTypeSelection.Location = new System.Drawing.Point(34, 252);
            this.AudioModelTypeSelection.Name = "AudioModelTypeSelection";
            this.AudioModelTypeSelection.Size = new System.Drawing.Size(186, 23);
            this.AudioModelTypeSelection.TabIndex = 5;
            // 
            // CheckBoxEnhanced
            // 
            this.CheckBoxEnhanced.AutoSize = true;
            this.CheckBoxEnhanced.Location = new System.Drawing.Point(34, 58);
            this.CheckBoxEnhanced.Name = "CheckBoxEnhanced";
            this.CheckBoxEnhanced.Size = new System.Drawing.Size(186, 19);
            this.CheckBoxEnhanced.TabIndex = 4;
            this.CheckBoxEnhanced.Text = "Enhanced Speech Recognition";
            this.CheckBoxEnhanced.UseVisualStyleBackColor = true;
            // 
            // CheckBoxPunctuation
            // 
            this.CheckBoxPunctuation.AutoSize = true;
            this.CheckBoxPunctuation.Location = new System.Drawing.Point(34, 83);
            this.CheckBoxPunctuation.Name = "CheckBoxPunctuation";
            this.CheckBoxPunctuation.Size = new System.Drawing.Size(150, 19);
            this.CheckBoxPunctuation.TabIndex = 3;
            this.CheckBoxPunctuation.Text = "Automatic Punctuation";
            this.CheckBoxPunctuation.UseVisualStyleBackColor = true;
            // 
            // CheckBoxWordTime
            // 
            this.CheckBoxWordTime.AutoSize = true;
            this.CheckBoxWordTime.Location = new System.Drawing.Point(34, 133);
            this.CheckBoxWordTime.Name = "CheckBoxWordTime";
            this.CheckBoxWordTime.Size = new System.Drawing.Size(119, 19);
            this.CheckBoxWordTime.TabIndex = 2;
            this.CheckBoxWordTime.Text = "Word Time Offset";
            this.CheckBoxWordTime.UseVisualStyleBackColor = true;
            // 
            // CheckBoxProfanity
            // 
            this.CheckBoxProfanity.AutoSize = true;
            this.CheckBoxProfanity.Location = new System.Drawing.Point(34, 108);
            this.CheckBoxProfanity.Name = "CheckBoxProfanity";
            this.CheckBoxProfanity.Size = new System.Drawing.Size(103, 19);
            this.CheckBoxProfanity.TabIndex = 1;
            this.CheckBoxProfanity.Text = "Profanity Filter";
            this.CheckBoxProfanity.UseVisualStyleBackColor = true;
            // 
            // CheckBoxAudioChannelRec
            // 
            this.CheckBoxAudioChannelRec.AutoSize = true;
            this.CheckBoxAudioChannelRec.Location = new System.Drawing.Point(34, 158);
            this.CheckBoxAudioChannelRec.Name = "CheckBoxAudioChannelRec";
            this.CheckBoxAudioChannelRec.Size = new System.Drawing.Size(220, 19);
            this.CheckBoxAudioChannelRec.TabIndex = 0;
            this.CheckBoxAudioChannelRec.Text = "Seperate Audio Channel Recognition";
            this.CheckBoxAudioChannelRec.UseVisualStyleBackColor = true;
            // 
            // TranscriptionApplicationForm
            // 
            this.AcceptButton = this.NextButton;
            this.AccessibleDescription = "Form to transcribe using google cloud";
            this.AccessibleName = "GCMassTranscriptionForm";
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 393);
            this.Controls.Add(this.PanelInputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TranscriptionApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GC Mass Transcriptor";
            this.PanelInputBox.ResumeLayout(false);
            this.PanelInputBox.PerformLayout();
            this.InitialPanel.ResumeLayout(false);
            this.InitialPanel.PerformLayout();
            this.ProcessingPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AudioChannelCount)).EndInit();
            this.SpeechContextGroupBox.ResumeLayout(false);
            this.SpeechContextGroupBox.PerformLayout();
            this.DiarizationGroupBox.ResumeLayout(false);
            this.DiarizationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumSpeakerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumSpeakerCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PanelInputBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel ProcessingPanel;
        private System.Windows.Forms.Panel InitialPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InitialPanelLabel1;
        private System.Windows.Forms.Button GCCFileBrowserButton;
        private System.Windows.Forms.RadioButton RadioButtonGCBFileStorage;
        private System.Windows.Forms.TextBox GCCFilePathTextBox;
        private System.Windows.Forms.RadioButton LocalFileStorageRadioButton;
        private System.Windows.Forms.Label InitialPanelLabel3;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.CheckBox CheckBoxEnhanced;
        private System.Windows.Forms.CheckBox CheckBoxPunctuation;
        private System.Windows.Forms.CheckBox CheckBoxWordTime;
        private System.Windows.Forms.CheckBox CheckBoxProfanity;
        private System.Windows.Forms.CheckBox CheckBoxAudioChannelRec;
        private System.Windows.Forms.ComboBox AudioModelTypeSelection;
        private System.Windows.Forms.Label SettingsLabel4;
        private System.Windows.Forms.ComboBox LanguageCodeSelection;
        private System.Windows.Forms.Label SettingsLabel3;
        private System.Windows.Forms.GroupBox SpeechContextGroupBox;
        private System.Windows.Forms.GroupBox DiarizationGroupBox;
        private System.Windows.Forms.CheckBox checkBoxSpeechContext;
        private System.Windows.Forms.CheckBox CheckBoxSpeakerDiarization;
        private System.Windows.Forms.NumericUpDown MaximumSpeakerCount;
        private System.Windows.Forms.NumericUpDown MinimumSpeakerCount;
        private System.Windows.Forms.Label SettingsLabel5;
        private System.Windows.Forms.Label SettingsLabel6;
        private System.Windows.Forms.Label SettingsLabel7;
        private System.Windows.Forms.TextBox SpeechContextFileLocationTextBox;
        private System.Windows.Forms.Button SpeechContextFileLocationButton;
        private System.Windows.Forms.Label SettingsLabel1;
        private System.Windows.Forms.Label SettingsLabel2;
        private System.Windows.Forms.NumericUpDown AudioChannelCount;
        private System.Windows.Forms.Button LocalFolderBrowserButton;
        private System.Windows.Forms.TextBox LocalFolderBrowserTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton RadioButtonLocal;
        private System.Windows.Forms.TextBox GCBFileStorageTextBox;
        private System.Windows.Forms.RadioButton GCBFileStorageRadioButton;
        private System.Windows.Forms.CheckBox CheckBoxSpeechContext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SaveTranscriptsFolderTextBox;
        private System.Windows.Forms.Button SaveTranscriptsFolderButton;
        private System.Windows.Forms.Label InitialPanelLabel2;
    }
}

