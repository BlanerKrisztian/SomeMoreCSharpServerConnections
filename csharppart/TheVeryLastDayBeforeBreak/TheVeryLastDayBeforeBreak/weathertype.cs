using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVeryLastDayBeforeBreak
{
    public class WeatherType
    {
        public int id               { get; set; }
        public string name          { get; set; }
        public double intensity     { get; set; }
        public string description   { get; set; }

        public WeatherType(string name, double intesity, string description)
        {
            this.name = name;
            this.intensity = intesity; //lol
            this.description = description;
        }
        public WeatherType(int id, string name, double intesity, string description)
        {
            this.id = id;
            this.name = name;
            this.intensity = intesity; //lol
            this.description = description;
        }
        public WeatherType()
        {/*
            this.id = 0;
            this.name = "N/A";
            this.intensity = 0.0; //lol
            this.description = null;*/
        }

        public override string ToString()
        {
            return $"{id}\t{name}\t{intensity}\t{description}";
        }
    }
}
