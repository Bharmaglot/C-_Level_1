using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods
{
    class Methods
    {
        //метод для размещения данных о городе, имени, фамилии с заданными координатами
        static public ProfileToCentr(string sity, string name, string surname, int ConsPositionХ, int ConsPositionY)//не совсем понял, что тут должно быть возвращаемым значением.
        {
         Console.SetCursorPosition(ConsPositionХ, ConsPositionY);
         Console.WriteLine($"{name} {surname}. {sity}");
        }

        private static double TakeNumDouble()
        {
            //первая точка
            return Convert.ToDouble(Console.ReadLine());//метод для удобства при написании. Получить сразу численные значения
        }

        private static double DistanseTwoPoint(double x1, double y1, double x2, double y2)//Метод для расстояния между точками.
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
        }
    }
}
