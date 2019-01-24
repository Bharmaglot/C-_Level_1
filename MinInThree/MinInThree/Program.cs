using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinInThree
{
    class Program
    {
        //Задание 1. Владимир Болбат. 
        //Написать метод, возвращающий минимальное из трёх чисел.
        
        //Метод возвращающий минимальное из трёх чисел.
        private static int MinInThree(int a, int b, int c)
        {
            int x;
            if (a < b && a < c)
            {
                x = a;
            }
            else if (b < c)
            {
                x = b;
            }
            else
            {
                x = c;
            }
            return x;
        }


        static void Main(string[] args)
        {
            //Ввод чисел, запрос метода, вывод минимального числа
            Console.WriteLine("Здравствуйте. Введите последовательно 3 любых числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int x;
            x = MinInThree(a, b, c);
            Console.WriteLine($"Наименьшим числом будет {x}");

        }


    }
}
