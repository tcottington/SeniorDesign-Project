using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Accord;
using System.Diagnostics;
namespace ExternalSD
{
    public partial class Form1 : Form
    {
        bool folderSelected = false;
        string outputPath = "";
        string finalVideoName = "FinalVideo.mp4";

        ScreenRecorder screenRec = new ScreenRecorder(new Rectangle(), "");
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFolder_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select an Output Folder";
            if(folderBrowser.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                outputPath = folderBrowser.SelectedPath;
                folderSelected = true;

                Rectangle bounds = Screen.FromControl(this).Bounds;
                screenRec = new ScreenRecorder(bounds, outputPath);
            }
            else
            {
                MessageBox.Show("Please select a folder", "Error");
            }
        }

        private void tmrRecord_Tick(object sender, EventArgs e)
        {
            screenRec.RecordAudio();
            screenRec.RecordVideo();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            if(folderSelected)
            {
                tmrRecord.Start();
            }
            else
            {
                MessageBox.Show("You must select an output folder before recording", "Error");
            }
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            tmrRecord.Stop();
            screenRec.Stop();
            Application.Restart();
        }

        private void UnityStart_btn_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "C:\\Program Files\\Unity\\Hub\\Editor\\2019.2.8f1\\Editor\\Unity.exe";
           
            p.Start();
        }
    }
}
