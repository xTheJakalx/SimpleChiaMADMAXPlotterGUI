using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChiaPlotter
{
    class Chia
    {
        public string Directory { get; set; }
        public string Executable { get; set; }
        public string Buckets { get; set; }
        public string Threads { get; set; }
        public string TotalPlots { get; set; }
        public string FarmerPublicKey { get; set; }
        public string PoolPublicKey { get; set; }
        public string TempDir1 { get; set; }
        public string TempDir2 { get; set; }
        public string TargetDir { get; set; }
    }
}
