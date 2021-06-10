using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC_Transcription_Form
{
    public partial class MainForm : Form
    {
        private PanelTypes currentPanel;
        private BackgroundWorker backgroundWorker;
        private bool formClosePending;
        

        enum PanelTypes
        {
            Initial,
            Settings,
            Processing
        }

        public MainForm()
        {
            InitializeComponent();
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += BackgroundWorker_Update;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_OnCompletion;
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_Update(object sender, DoWorkEventArgs e)
        {
            while (!backgroundWorker.CancellationPending)
            {
                Invoke((Action) (() => { InputCheck(); PanelUpdate(); }));
            }
        }

        private void BackgroundWorker_OnCompletion(object sender, RunWorkerCompletedEventArgs e)
        {
            if (formClosePending)
            {
                Close();
                formClosePending = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                formClosePending = true;
                backgroundWorker.CancelAsync();
                e.Cancel = true;
                //this.Enabled = false;
                //return;
            }
            base.OnFormClosing(e);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            currentPanel += 1;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            currentPanel -= 1;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }


        private void GCCFolderBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog GCCFileDialog = new OpenFileDialog();
            GCCFileDialog.ShowDialog();
            GCCFilePathTextBox.Text = GCCFileDialog.FileName;
        }

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

        private void InputCheck()
        {
            if (currentPanel == PanelTypes.Initial)
            {

                if (GCCFilePathTextBox.Text.ToLower().Contains(".json") && (InitialPanelRadioButtonLocal.Checked == true || InitialPanelRadioButtonGCB.Checked == true))
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
                NextButton.Enabled = true;
                BackButton.Enabled = true;
            }
            else if (currentPanel == PanelTypes.Processing)
            {
                NextButton.Enabled = false;
                BackButton.Enabled = true;
            }
        }
    }
}