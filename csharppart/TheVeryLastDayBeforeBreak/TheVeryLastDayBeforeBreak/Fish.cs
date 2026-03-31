using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVeryLastDayBeforeBreak
{
    public class Fish
    {
        public int id { get; set; }
        public string typeOfFish { get; set; }
        public double weight { get; set; }
        /*
        public Fish(string type, double weighht)
        {
            typeOfFish = type;
            weight = weighht;
        }*/
        public override string ToString()
        {
            return $"{id}\t{typeOfFish}\t{weight}kg";
        }
    }
}
