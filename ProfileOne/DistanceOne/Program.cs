using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceOne
{
    class Program
    {
        static void Main(string[] args)
        {   //Первая точка
            Console.WriteLine("Здравствуйте. Давайте рассчитаем расстояние меджу двумя точками на плоскости координат.\nДля начала, пожалуйста, введите значение х1:");
            double x1 = TakeNumDouble();
            Console.WriteLine("Теперь укажите значение Y1:");
            double y1 = TakeNumDouble();

            //вторая точка
            Console.WriteLine($"И так, первая точка располагается в координатах {x1} по оси Х и {y1} по оси Y.Теперь укажите значение Х2 для второй точки:");
            double x2 = TakeNumDouble();
            Console.WriteLine($"И, наконец, сообщите расположение второй точки относительно оси Y (Y2)");
            double y2 = TakeNumDouble();
            double r = DistanseTwoPoint(x1, y1, x2, y2);
            Console.WriteLine($"И так, расстояние между вашими точками составит {r:F}, но это примерно. Спасибо за внимание.");
            Console.ReadKey();
        }

        private static double TakeNumDouble()
        {
            //первая точка
            return Convert.ToDouble(Console.ReadLine());//метод для удобства при написании.
        }

        private static double DistanseTwoPoint(double x1, double y1, double x2, double y2)//Метод для расстояния между точками.
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
