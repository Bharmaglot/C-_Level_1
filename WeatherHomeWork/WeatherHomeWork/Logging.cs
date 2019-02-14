using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherHomeWork
{
    class Logging
    {
        internal static void Log(string Msg)
        {
            using (var sw = new System.IO.StreamWriter("Data.log", true))
            {
                sw.WriteLine(Msg);
            }
        }
    }
}
