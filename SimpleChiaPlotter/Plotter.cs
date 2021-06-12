using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleChiaPlotter
{
    class Plotter
    {
        public void Run(Chia chia, bool tempdir2)
        {
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = $"{chia.Directory}\\{chia.Executable}";
            // reduced amount of args for MADMAX plotter
            info.Arguments = $" -n {chia.TotalPlots} -r {chia.Threads} -u {chia.Buckets} -t {chia.TempDir1} -d {chia.TargetDir} -p {chia.PoolPublicKey} -f {chia.FarmerPublicKey}";
            if (tempdir2) { info.Arguments += $" -2 {chia.TempDir2}"; }
            info.WorkingDirectory = chia.Directory;
            p.StartInfo = info;
            try
            {
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error Ocurred! \r\n Message: {ex.Message}", "Error");
            }

        }
    }
}
