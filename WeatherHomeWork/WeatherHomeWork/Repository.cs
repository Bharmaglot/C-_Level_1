using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WeatherHomeWork
{
    class Repository
    {
        List<City> db = new List<City>();

        public List<City> Citys { get { return this.db; } } 

        Random random = new Random();

        public Repository()
        {
            for (int i = 0; i <20; i++)
            {
                db.Add(new City()
                {
                    CityName = $"Город_{i + 1}",
                    TemperatureMin = random.Next(14, 19),
                    TemperatureMax = random.Next(10, 14),
                    PressureMin = random.Next(720, 745),
                    PressureMax = random.Next(745, 760)
                });
            }

        }
        public void PrintData()
        { foreach (var item in db)
            {
                Debug.WriteLine(item.Print());
             }
        }
    }
}
