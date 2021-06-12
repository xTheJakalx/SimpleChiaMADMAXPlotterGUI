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
using System.Xml;
using System.Xml.Linq;

namespace SimpleChiaPlotter
{
    public partial class FrmSettings : Form
    {
        private Chia chia = new Chia();
        IniFile MyIni = new IniFile("SimpleChiaMADMAXPlotter.ini");

        public FrmSettings()
        {
            InitializeComponent();
            chia.Directory = MyIni.Read("Directory");
            chia.Executable = MyIni.Read("Executable");
            chia.Buckets = MyIni.Read("Buckets");
            chia.Threads = MyIni.Read("Threads");
            chia.TotalPlots = MyIni.Read("TotalPlots");
            chia.FarmerPublicKey = MyIni.Read("FarmerPublicKey");
            chia.PoolPublicKey = MyIni.Read("PoolPublicKey");
            chia.TempDir1 = MyIni.Read("TempDir1");
            chia.TempDir2 = MyIni.Read("TempDir2");
            chia.TargetDir = MyIni.Read("TargetDir");
            textBoxDeamonDirectory.Text = chia.Directory;
            textBoxExecutable.Text = chia.Executable;
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    chia.Directory = fbd.SelectedPath;
                    textBoxDeamonDirectory.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnExecutable_Click(object sender, EventArgs e)
        {
            using (var openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = chia.Directory;
                openFileDialog1.Filter = "Executable files (*.exe)|*.exe";
                openFileDialog1.FilterIndex = 0;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    chia.Executable = openFileDialog1.SafeFileName;
                    textBoxExecutable.Text = openFileDialog1.SafeFileName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            this.Close();
        }
    }
}
