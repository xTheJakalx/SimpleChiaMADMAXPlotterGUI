using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleChiaPlotter
{
    public partial class FrmPlotter : Form
    {
        private Chia chia = new Chia();
        IniFile MyIni = new IniFile("SimpleChiaMADMAXPlotter.ini");

        public FrmPlotter()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig()
        {
            string curFile = "SimpleChiaMADMAXPlotter.ini";
            if (File.Exists(curFile))
            {
                try
                {
                    MyIni = new IniFile("SimpleChiaMADMAXPlotter.ini");
                    textBoxTempDir1.Text = MyIni.Read("TempDir1");
                    textBoxTempDir2.Text = MyIni.Read("TempDir2");
                    textBoxFinalDir.Text = MyIni.Read("TargetDir");
                    textBoxFarmerPublicKey.Text = MyIni.Read("FarmerPublicKey");
                    textBoxPoolPublicKey.Text = MyIni.Read("PoolPublicKey");
                }
                catch (Exception)
                {
                    CreateConfig();
                    MyIni = new IniFile("SimpleChiaMADMAXPlotter.ini");
                }
            }
            else
            {
                CreateConfig();
            }
            var chia = new Chia
            {
                Directory = MyIni.Read("Directory"),
                Executable = MyIni.Read("Executable"),
                Buckets = MyIni.Read("Buckets"),
                Threads = MyIni.Read("Threads"),
                TotalPlots = MyIni.Read("TotalPlots"),
                FarmerPublicKey = MyIni.Read("FarmerPublicKey"),
                PoolPublicKey = MyIni.Read("PoolPublicKey"),
                TempDir1 = MyIni.Read("TempDir1"),
                TempDir2 = MyIni.Read("TempDir2"),
                TargetDir = MyIni.Read("TargetDir")
            };
            if (chia.Directory == "")
            {
                MessageBox.Show("Please configure MADMAX plotter Directory!", "Urgent!");
                FrmSettings f2 = new FrmSettings();
                f2.ShowDialog();
            }
        }

        private void CreateConfig()
        {
            MyIni.Write("Directory", null);
            MyIni.Write("Executable", "chia_plot.exe");
            MyIni.Write("Buckets", "256");
            MyIni.Write("Threads", "4");
            MyIni.Write("TotalPlots", "1");
            MyIni.Write("FarmerPublicKey", null);
            MyIni.Write("PoolPublicKey", null);
            MyIni.Write("TempDir1", null);
            MyIni.Write("TempDir2", null);
            MyIni.Write("TargetDir", null);
        }

        private void SaveConfig(Chia chia)
        {
            MyIni.Write("Directory", chia.Directory);
            MyIni.Write("Executable", chia.Executable);
            MyIni.Write("Buckets", chia.Buckets);
            MyIni.Write("Threads", chia.Threads);
            MyIni.Write("TotalPlots", chia.TotalPlots);
            MyIni.Write("FarmerPublicKey", chia.FarmerPublicKey);
            MyIni.Write("PoolPublicKey", chia.PoolPublicKey);
            MyIni.Write("TempDir1", chia.TempDir1);
            MyIni.Write("TempDir2", chia.TempDir2);
            MyIni.Write("TargetDir", chia.TargetDir);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit program
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open about form
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open settings form
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            var chia = new Chia
            {
                Directory = MyIni.Read("Directory"),
                Executable = MyIni.Read("Executable"),
                Threads = textBoxThreads.Text,
                Buckets = textBoxBuckets.Text,
                TotalPlots = textBoxPlotCount.Text,
                FarmerPublicKey = textBoxFarmerPublicKey.Text,
                PoolPublicKey = textBoxPoolPublicKey.Text,
                TempDir1 = textBoxTempDir1.Text,
                TempDir2 = textBoxTempDir2.Text,
                TargetDir = textBoxFinalDir.Text
            };
            SaveConfig(chia);
            if (textBoxTempDir1.Text == "" || textBoxFinalDir.Text == "" || (checkBox2ndTempDir.Checked == true && textBoxTempDir2.Text == ""))
            {
                    MessageBox.Show("Please configure plotting directories!", "Urgent!");
            }
            else
            {
                var plotter = new Plotter();
                var tempDir2 = false;
                if (checkBox2ndTempDir.Checked)
                {
                    tempDir2 = true;
                }
                plotter.Run(chia, tempDir2);
            }

        }

        private void btnTempDir1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    chia.TempDir1 = fbd.SelectedPath + "\\";
                    textBoxTempDir1.Text = fbd.SelectedPath + "\\";
                    MyIni.Write("TempDir1", chia.TempDir1);
                    LoadConfig();
                }
            }
        }

        private void btnTempDir2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    chia.TempDir2 = fbd.SelectedPath + "\\";
                    textBoxTempDir2.Text = fbd.SelectedPath + "\\";
                    MyIni.Write("TempDir2", chia.TempDir2);
                    LoadConfig();
                }
            }
        }

        private void btnFinalDir_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    chia.TargetDir = fbd.SelectedPath + "\\";
                    textBoxFinalDir.Text = fbd.SelectedPath + "\\";
                    MyIni.Write("TargetDir", chia.TargetDir);
                    LoadConfig();
                }
            }
        }

        private void BuyMeACoffee()
        {
            System.Diagnostics.Process.Start("https://buymeacoffee.com/TheJakal");
        }

        private void btnBuyMeACoffee_Click(object sender, EventArgs e)
        {
            BuyMeACoffee();
        }

        private void lblPlotterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PlotterLink();
        }

        private void PlotterLink()
        {
            System.Diagnostics.Process.Start("https://github.com/stotiks/chia-plotter");
        }
    }
}
