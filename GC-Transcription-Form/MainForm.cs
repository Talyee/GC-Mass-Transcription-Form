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
        public MainForm()
        {
            InitializeComponent();
            InitialPanel.BringToFront();
            NextButton.Enabled = false;
            BackButton.Enabled = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            InitialPanel.Hide();
            ProcessingPanel.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProcessingPanel.Hide();
            InitialPanel.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Dispose();
        }

        private void InputCheck()
        {
            
        }

        private void GCCFolderBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog GCCFileDialog = new OpenFileDialog();
            GCCFileDialog.ShowDialog();
        }

    }
}
