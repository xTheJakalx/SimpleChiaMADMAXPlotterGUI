using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChiaPlotter
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void linkLabelAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLink()
        {
            linkLabelAuthor.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/xTheJakalx/SimpleChiaMADMAXPlotterGUI");
        }
        private void BuyMeACoffee()
        {
            System.Diagnostics.Process.Start("https://buymeacoffee.com/TheJakal");
        }

        private void btnBuyMeACoffee_Click(object sender, EventArgs e)
        {
            BuyMeACoffee();
        }
    }
}
