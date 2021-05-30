
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
            this.InitialPanel = new System.Windows.Forms.Panel();
            this.InitialPanelRadioButtonLocal = new System.Windows.Forms.RadioButton();
            this.InitialPanelLabel2 = new System.Windows.Forms.Label();
            this.InitialPanelRadioButtonGCB = new System.Windows.Forms.RadioButton();
            this.GCCFilePathTextBox = new System.Windows.Forms.TextBox();
            this.GCCFolderBrowser = new System.Windows.Forms.Button();
            this.InitialPanelLabel1 = new System.Windows.Forms.Label();
            this.InputBox.SuspendLayout();
            this.ProcessingPanel.SuspendLayout();
            this.InitialPanel.SuspendLayout();
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
            this.ProcessingPanel.Controls.Add(this.InitialPanel);
            this.ProcessingPanel.Controls.Add(this.OutputTextBox);
            this.ProcessingPanel.Controls.Add(this.ProgressBar);
            this.ProcessingPanel.Location = new System.Drawing.Point(-5, -9);
            this.ProcessingPanel.Name = "ProcessingPanel";
            this.ProcessingPanel.Size = new System.Drawing.Size(663, 351);
            this.ProcessingPanel.TabIndex = 8;
            // 
            // InitialPanel
            // 
            this.InitialPanel.Controls.Add(this.InitialPanelRadioButtonLocal);
            this.InitialPanel.Controls.Add(this.InitialPanelLabel2);
            this.InitialPanel.Controls.Add(this.InitialPanelRadioButtonGCB);
            this.InitialPanel.Controls.Add(this.GCCFilePathTextBox);
            this.InitialPanel.Controls.Add(this.GCCFolderBrowser);
            this.InitialPanel.Controls.Add(this.InitialPanelLabel1);
            this.InitialPanel.Location = new System.Drawing.Point(6, 7);
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
            this.InputBox.ResumeLayout(false);
            this.InputBox.PerformLayout();
            this.ProcessingPanel.ResumeLayout(false);
            this.InitialPanel.ResumeLayout(false);
            this.InitialPanel.PerformLayout();
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
    }
}

