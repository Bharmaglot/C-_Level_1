using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOdd
{
    class Program
    {
        //Задание 3. Владимир Болбат.
        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите любые числа. Для завершения наберите 0");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (a != 0)
            {
                if (a > 0 && (a + 1) % 2 == 0)
                {
                    sum = sum + a;
                }
                a = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"Сумма всех нечетных положительных чисел составит: {sum}");
        }
    }
}
