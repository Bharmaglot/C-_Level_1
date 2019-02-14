using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherHomeWork
{
    class City
    {
        public string CityName { get; set; }

        public int TemperatureMax { get; set; }

        public int TemperatureMin { get; set; }

        public int PressureMax { get; set; }

        public int PressureMin { get; set; }

        public override string ToString()
        {
            return $"{this.CityName,10}";
        }

        internal string Print()
        {
            return $" {this.CityName,10} {TemperatureMin,3} - {TemperatureMax,3} °c {PressureMin} - {PressureMax} мм.рт.ст.";
        }
    }
}
