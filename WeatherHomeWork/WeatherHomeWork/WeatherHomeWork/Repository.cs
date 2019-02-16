using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Collections;
using System.Net;
using System.Xml.Linq;

namespace WeatherHomeWork
{
    class Repository
    {
        List<City> db = new List<City>();

        public List<City> Citys { get { return this.db; } } 

        Random random = new Random();

        public Repository()
        {

            ArrayList citysBase = new ArrayList();
            ArrayList adressBase = new ArrayList();
            string testFile = @"Citys.txt";
            if (File.Exists(testFile))
            {
                StreamReader sr = new StreamReader("Citys.txt");

                while (!sr.EndOfStream)
                {
                    try
                    {
                        string[] city = sr.ReadLine().Split(' ');
                        citysBase.Add(city[0]);
                        adressBase.Add(city[1]);
                    }
                    catch
                    {

                    }
                }
                sr.Close();
            }
            else
            {
                string[] city = { "База не найдена. Есть МСК", "https://xml.meteoservice.ru/export/gismeteo/point/37.xml" };
                citysBase.Add(city[0]);
                adressBase.Add(city[1]);
            }



            for (int i = 0; i <citysBase.Count; i++)
            {
                WebClient webClient = new WebClient();
                string data = webClient.DownloadString($"{adressBase[i]}");
                var weatherCollection = XDocument.Parse(data)
                                                .Descendants("MMWEATHER")
                                                .Descendants("REPORT")
                                                .Descendants("TOWN")
                                                .Descendants("FORECAST").ToArray();

                db.Add(new City()
                {
                    CityName = $" {citysBase[i]}",
                    
                    TemperatureMin = Convert.ToInt32($"{weatherCollection[0].Element("TEMPERATURE").Attribute("max").Value}"),
                    TemperatureMax = Convert.ToInt32($"{weatherCollection[0].Element("TEMPERATURE").Attribute("min").Value}"),
                    PressureMin = Convert.ToInt32($"{weatherCollection[0].Element("PRESSURE").Attribute("max").Value}"),
                    PressureMax = Convert.ToInt32($"{weatherCollection[0].Element("PRESSURE").Attribute("min").Value}"),
                    CityDate = $"{weatherCollection[0].Attribute("day").Value}.{weatherCollection[0].Attribute("month").Value}",
                    CityTime = $"{weatherCollection[0].Attribute("hour").Value}"
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
