using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTR_Invasion_Tracker.Classes
{
    internal class Invasions
    {
        public object? error { get; set; }
        public Dictionary<string, District> invasions { get; set; }
        public int lastUpdated { get; set; }

    }
}
