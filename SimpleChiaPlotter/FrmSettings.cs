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
        // create chia class and MyIni class
        private Chia chia = new Chia();
        IniFile MyIni = new IniFile("SimpleChiaMADMAXPlotter.ini");

        public FrmSettings()
        {
            InitializeComponent();
            LoadConfig();
            textBoxDeamonDirectory.Text = chia.Directory;
            textBoxExecutable.Text = chia.Executable;
        }
        /// <summary>
        /// Load settings from ini file
        /// </summary>
        private void LoadConfig()
        {
            chia.Directory = MyIni.Read("Directory");
            chia.Executable = MyIni.Read("Executable");
        }
        /// <summary>
        /// Change MADMAX directory
        /// </summary>
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
        /// <summary>
        /// Change MADMAX executable
        /// </summary>
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
        /// <summary>
        /// Save settings to ini file
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            MyIni.Write("Directory", chia.Directory);
            MyIni.Write("Executable", chia.Executable);
            this.Close();
        }
    }
}
