using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVeryLastDayBeforeBreak
{
    public class Film
    {
        public string id { get; set; }
        public string cim { get; set; }
        public int megjelenes { get; set; }
        public double ertekeles { get; set; }

        public override string ToString()
        {
            return $"{id}\t{cim}\t{megjelenes}\t{ertekeles}♦";
        }
    }
}
