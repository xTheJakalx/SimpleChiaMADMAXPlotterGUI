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
        /// <summary>
        /// 
        /// Simple class for building and starting the MADMAX process.
        /// 
        /// </summary>
        /// <param name="chia"> Passes the chia class into the function. </param>
        /// <param name="tempdir2"> bool for if user wants to use tempdir2. </param>
        /// <param name="wait">bool for if user wants to use wait for copy. </param>
        /// <param name="tmpToggle">bool for if user wants to toggle temp directories every new plot. </param>
        public void Run(Chia chia, bool tempdir2, bool wait, bool tmpToggle)
        {
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = $"{chia.Directory}\\{chia.Executable}";
            // minimum args for MADMAX plotter
            info.Arguments = $" -n {chia.TotalPlots} -r {chia.Threads} -u {chia.Buckets} -v {chia.Buckets3} -t {chia.TempDir1} -d {chia.TargetDir} -p {chia.PoolPublicKey} -f {chia.FarmerPublicKey}";
            // check if bools are true and add them to arguments
            if (tempdir2) { info.Arguments += $" -2 {chia.TempDir2}"; }
            if (wait) { info.Arguments += $" -w"; }
            if (tmpToggle) { info.Arguments += $" -G"; }
            info.WorkingDirectory = chia.Directory;
            p.StartInfo = info;
            try
            {
                p.Start();
            }
            catch (Exception ex)
            {
                // show error message to user
                MessageBox.Show($" Error Ocurred! \r\n Message: {ex.Message}", "Error");
            }

        }
    }
}
