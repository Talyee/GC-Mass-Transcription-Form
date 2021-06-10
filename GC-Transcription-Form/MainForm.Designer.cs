
namespace GC_Transcription_Form
{
    partial class MainForm
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
            this.InputBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcessingPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.InitialPanel = new System.Windows.Forms.Panel();
            this.InitialPanelRadioButtonLocal = new System.Windows.Forms.RadioButton();
            this.InitialPanelLabel2 = new System.Windows.Forms.Label();
            this.InitialPanelRadioButtonGCB = new System.Windows.Forms.RadioButton();
            this.GCCFilePathTextBox = new System.Windows.Forms.TextBox();
            this.GCCFolderBrowser = new System.Windows.Forms.Button();
            this.InitialPanelLabel1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.SettingsMainLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxEnhanced = new System.Windows.Forms.CheckBox();
            this.checkBoxPunctuation = new System.Windows.Forms.CheckBox();
            this.checkBoxWordTime = new System.Windows.Forms.CheckBox();
            this.checkBoxProfanity = new System.Windows.Forms.CheckBox();
            this.checkBoxAudioChannelRec = new System.Windows.Forms.CheckBox();
            this.InputBox.SuspendLayout();
            this.ProcessingPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.InitialPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // InputBox
            // 
            this.InputBox.Controls.Add(this.BackButton);
            this.InputBox.Controls.Add(this.CancelButton);
            this.InputBox.Controls.Add(this.label2);
            this.InputBox.Controls.Add(this.NextButton);
            this.InputBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InputBox.Location = new System.Drawing.Point(-5, 334);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(663, 80);
            this.InputBox.TabIndex = 7;
            this.InputBox.TabStop = false;
            this.InputBox.Text = "GC Mass Transcriptor";
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
            this.SettingsPanel.Controls.Add(this.label8);
            this.SettingsPanel.Controls.Add(this.numericUpDown3);
            this.SettingsPanel.Controls.Add(this.SettingsMainLabel);
            this.SettingsPanel.Controls.Add(this.groupBox2);
            this.SettingsPanel.Controls.Add(this.groupBox1);
            this.SettingsPanel.Controls.Add(this.label4);
            this.SettingsPanel.Controls.Add(this.comboBox2);
            this.SettingsPanel.Controls.Add(this.label3);
            this.SettingsPanel.Controls.Add(this.comboBox1);
            this.SettingsPanel.Controls.Add(this.checkBoxEnhanced);
            this.SettingsPanel.Controls.Add(this.checkBoxPunctuation);
            this.SettingsPanel.Controls.Add(this.checkBoxWordTime);
            this.SettingsPanel.Controls.Add(this.checkBoxProfanity);
            this.SettingsPanel.Controls.Add(this.checkBoxAudioChannelRec);
            this.SettingsPanel.Location = new System.Drawing.Point(0, 7);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(663, 352);
            this.SettingsPanel.TabIndex = 7;
            // 
            // InitialPanel
            // 
            this.InitialPanel.Controls.Add(this.InitialPanelRadioButtonLocal);
            this.InitialPanel.Controls.Add(this.InitialPanelLabel2);
            this.InitialPanel.Controls.Add(this.InitialPanelRadioButtonGCB);
            this.InitialPanel.Controls.Add(this.GCCFilePathTextBox);
            this.InitialPanel.Controls.Add(this.GCCFolderBrowser);
            this.InitialPanel.Controls.Add(this.InitialPanelLabel1);
            this.InitialPanel.Location = new System.Drawing.Point(0, 0);
            this.InitialPanel.Name = "InitialPanel";
            this.InitialPanel.Size = new System.Drawing.Size(663, 344);
            this.InitialPanel.TabIndex = 5;
            // 
            // InitialPanelRadioButtonLocal
            // 
            this.InitialPanelRadioButtonLocal.AutoSize = true;
            this.InitialPanelRadioButtonLocal.Location = new System.Drawing.Point(53, 289);
            this.InitialPanelRadioButtonLocal.Name = "InitialPanelRadioButtonLocal";
            this.InitialPanelRadioButtonLocal.Size = new System.Drawing.Size(122, 19);
            this.InitialPanelRadioButtonLocal.TabIndex = 6;
            this.InitialPanelRadioButtonLocal.TabStop = true;
            this.InitialPanelRadioButtonLocal.Text = "My Local Machine";
            this.InitialPanelRadioButtonLocal.UseVisualStyleBackColor = true;
            // 
            // InitialPanelLabel2
            // 
            this.InitialPanelLabel2.AutoSize = true;
            this.InitialPanelLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InitialPanelLabel2.Location = new System.Drawing.Point(53, 182);
            this.InitialPanelLabel2.Name = "InitialPanelLabel2";
            this.InitialPanelLabel2.Size = new System.Drawing.Size(455, 21);
            this.InitialPanelLabel2.TabIndex = 5;
            this.InitialPanelLabel2.Text = "Where would you like your transcripted documents to be saved?";
            // 
            // InitialPanelRadioButtonGCB
            // 
            this.InitialPanelRadioButtonGCB.AutoSize = true;
            this.InitialPanelRadioButtonGCB.Location = new System.Drawing.Point(53, 239);
            this.InitialPanelRadioButtonGCB.Name = "InitialPanelRadioButtonGCB";
            this.InitialPanelRadioButtonGCB.Size = new System.Drawing.Size(137, 19);
            this.InitialPanelRadioButtonGCB.TabIndex = 4;
            this.InitialPanelRadioButtonGCB.TabStop = true;
            this.InitialPanelRadioButtonGCB.Text = "Google Cloud Bucket";
            this.InitialPanelRadioButtonGCB.UseVisualStyleBackColor = true;
            // 
            // GCCFilePathTextBox
            // 
            this.GCCFilePathTextBox.Location = new System.Drawing.Point(53, 114);
            this.GCCFilePathTextBox.Name = "GCCFilePathTextBox";
            this.GCCFilePathTextBox.Size = new System.Drawing.Size(484, 23);
            this.GCCFilePathTextBox.TabIndex = 3;
            // 
            // GCCFolderBrowser
            // 
            this.GCCFolderBrowser.Location = new System.Drawing.Point(543, 114);
            this.GCCFolderBrowser.Name = "GCCFolderBrowser";
            this.GCCFolderBrowser.Size = new System.Drawing.Size(75, 23);
            this.GCCFolderBrowser.TabIndex = 2;
            this.GCCFolderBrowser.Text = "Browse...";
            this.GCCFolderBrowser.UseVisualStyleBackColor = true;
            this.GCCFolderBrowser.Click += new System.EventHandler(this.GCCFolderBrowser_Click);
            // 
            // InitialPanelLabel1
            // 
            this.InitialPanelLabel1.AutoSize = true;
            this.InitialPanelLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InitialPanelLabel1.Location = new System.Drawing.Point(53, 54);
            this.InitialPanelLabel1.Name = "InitialPanelLabel1";
            this.InitialPanelLabel1.Size = new System.Drawing.Size(464, 21);
            this.InitialPanelLabel1.TabIndex = 1;
            this.InitialPanelLabel1.Text = "Please select the path to your Google Cloud Credentials JSON file:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Audio Channel Count";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(34, 204);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(186, 23);
            this.numericUpDown3.TabIndex = 12;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingsMainLabel
            // 
            this.SettingsMainLabel.AutoSize = true;
            this.SettingsMainLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsMainLabel.Location = new System.Drawing.Point(34, 14);
            this.SettingsMainLabel.Name = "SettingsMainLabel";
            this.SettingsMainLabel.Size = new System.Drawing.Size(245, 21);
            this.SettingsMainLabel.TabIndex = 11;
            this.SettingsMainLabel.Text = "Please Select The Desired Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Location = new System.Drawing.Point(311, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 142);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speech Context";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Speech Context Text File Location";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(6, 22);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(147, 19);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "Enable Speech Context";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Location = new System.Drawing.Point(311, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 135);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diarization";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Minimum Speakers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Maximum Speakers";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(200, 84);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown2.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(27, 84);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 1;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 22);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(164, 19);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "Enable Speaker Diarization";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Language Code";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(34, 299);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 23);
            this.comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Phone Call",
            "Video",
            "Voice Commands"});
            this.comboBox1.Location = new System.Drawing.Point(34, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // checkBoxEnhanced
            // 
            this.checkBoxEnhanced.AutoSize = true;
            this.checkBoxEnhanced.Location = new System.Drawing.Point(34, 58);
            this.checkBoxEnhanced.Name = "checkBoxEnhanced";
            this.checkBoxEnhanced.Size = new System.Drawing.Size(186, 19);
            this.checkBoxEnhanced.TabIndex = 4;
            this.checkBoxEnhanced.Text = "Enhanced Speech Recognition";
            this.checkBoxEnhanced.UseVisualStyleBackColor = true;
            // 
            // checkBoxPunctuation
            // 
            this.checkBoxPunctuation.AutoSize = true;
            this.checkBoxPunctuation.Location = new System.Drawing.Point(34, 83);
            this.checkBoxPunctuation.Name = "checkBoxPunctuation";
            this.checkBoxPunctuation.Size = new System.Drawing.Size(150, 19);
            this.checkBoxPunctuation.TabIndex = 3;
            this.checkBoxPunctuation.Text = "Automatic Punctuation";
            this.checkBoxPunctuation.UseVisualStyleBackColor = true;
            // 
            // checkBoxWordTime
            // 
            this.checkBoxWordTime.AutoSize = true;
            this.checkBoxWordTime.Location = new System.Drawing.Point(34, 133);
            this.checkBoxWordTime.Name = "checkBoxWordTime";
            this.checkBoxWordTime.Size = new System.Drawing.Size(119, 19);
            this.checkBoxWordTime.TabIndex = 2;
            this.checkBoxWordTime.Text = "Word Time Offset";
            this.checkBoxWordTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxProfanity
            // 
            this.checkBoxProfanity.AutoSize = true;
            this.checkBoxProfanity.Location = new System.Drawing.Point(34, 108);
            this.checkBoxProfanity.Name = "checkBoxProfanity";
            this.checkBoxProfanity.Size = new System.Drawing.Size(103, 19);
            this.checkBoxProfanity.TabIndex = 1;
            this.checkBoxProfanity.Text = "Profanity Filter";
            this.checkBoxProfanity.UseVisualStyleBackColor = true;
            // 
            // checkBoxAudioChannelRec
            // 
            this.checkBoxAudioChannelRec.AutoSize = true;
            this.checkBoxAudioChannelRec.Location = new System.Drawing.Point(34, 158);
            this.checkBoxAudioChannelRec.Name = "checkBoxAudioChannelRec";
            this.checkBoxAudioChannelRec.Size = new System.Drawing.Size(220, 19);
            this.checkBoxAudioChannelRec.TabIndex = 0;
            this.checkBoxAudioChannelRec.Text = "Seperate Audio Channel Recognition";
            this.checkBoxAudioChannelRec.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AcceptButton = this.NextButton;
            this.AccessibleDescription = "Form to transcribe using google cloud";
            this.AccessibleName = "GCMassTranscriptionForm";
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 393);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GC Mass Transcriptor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.InputBox.ResumeLayout(false);
            this.InputBox.PerformLayout();
            this.ProcessingPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.InitialPanel.ResumeLayout(false);
            this.InitialPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox InputBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel ProcessingPanel;
        private System.Windows.Forms.Panel InitialPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InitialPanelLabel1;
        private System.Windows.Forms.Button GCCFolderBrowser;
        private System.Windows.Forms.RadioButton InitialPanelRadioButtonGCB;
        private System.Windows.Forms.TextBox GCCFilePathTextBox;
        private System.Windows.Forms.RadioButton InitialPanelRadioButtonLocal;
        private System.Windows.Forms.Label InitialPanelLabel2;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.CheckBox checkBoxEnhanced;
        private System.Windows.Forms.CheckBox checkBoxPunctuation;
        private System.Windows.Forms.CheckBox checkBoxWordTime;
        private System.Windows.Forms.CheckBox checkBoxProfanity;
        private System.Windows.Forms.CheckBox checkBoxAudioChannelRec;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SettingsMainLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}

