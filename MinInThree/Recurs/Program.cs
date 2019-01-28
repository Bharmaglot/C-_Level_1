using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurs
{
    //Задание 7. Владимир Болбат.
    //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    //б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 7;
            int sum = 0;
            cycle(a, b, sum);

        }
        static void cycle(int a, int b, int sum)
        {
            Console.Write($" {a} ");
            sum = sum + a;
            if (a < b) cycle(a + 1, b, sum);
            else
            {
                Console.WriteLine("\nСумма чисел: " + sum);
            }
        }
    }
}
