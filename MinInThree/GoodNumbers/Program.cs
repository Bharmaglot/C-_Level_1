using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodNumbers
{
    using System;

    class Program
    {
        //Задание 6. Владимир Болбат.
        //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
        //«Хорошим» называется число, которое делится на сумму своих цифр.
        //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

        static long Sum(long a)
        {
            long s = 0;
            while (a > 0)
            {
                s = s + a % 10;
                a = a / 10;
            }
            return s;
        }

        static void Main(string[] args)
        {
            int y = 1;
            DateTime start = DateTime.Now;
            for (long i = 1; i <= 1000000000; i++)
            {
                long x = Sum(i);//cумма чисел

                if (i % x == 0)
                {
                    y++;
                }
            }
            Console.WriteLine($"Количество хороших числел: {y}");
            Console.WriteLine(DateTime.Now - start);
            Console.ReadKey();
        }
    }
}
