using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChiaPlotter
{
    /// <summary>
    /// Chia class that holds all needed information
    /// </summary>
    class Chia
    {
        public string Directory { get; set; }
        public string Executable { get; set; }
        public string Buckets { get; set; }
        public string Buckets3 { get; set; }
        public string Threads { get; set; }
        public string TotalPlots { get; set; }
        public string FarmerPublicKey { get; set; }
        public string PoolPublicKey { get; set; }
        public string NFTAddress { get; set; }
        public string TempDir1 { get; set; }
        public string TempDir2 { get; set; }
        public string TargetDir { get; set; }
        public bool TempDir2Enabled { get; set; }
        public bool TempToggle { get; set; }
        public bool WaitForCopy { get; set; }
        public bool EnableBuckets3 { get; set; }
        public bool NFTEnabled { get; set; }
        public bool PoolKeyEnabled { get; set; }
    }
}
