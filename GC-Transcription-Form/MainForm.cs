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

        enum PanelTypes
        {
            Initial,
            Settings,
            Processing
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            currentPanel = PanelTypes.Initial;
            NextButton.Enabled = false;
            BackButton.Enabled = false;
        }

        private void Update()
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            currentPanel += 1;
            PanelUpdate();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            currentPanel -= 1;
            PanelUpdate();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Dispose();
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
            InputCheck();
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