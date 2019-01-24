using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapOne
{

    class Program
    {
        static void Main(string[] args)
        {
            //обмен значениями переменных a и b с использованием третьей переменной (с)
            int a = takeNumInt();
            int b = takeNumInt();
            Console.WriteLine($"a = {a} b = {b}");
            int c = b;
            b = a;
            a = c;
            Console.WriteLine($"a = {a} b = {b}");


            //обмен значениями переменных a и b без использования третьей переменной.

            int x = takeNumInt();
            int y = takeNumInt();
            Console.WriteLine($"x = {x} y = {y}");
            x = x + y; //сумма переменных 2+3 =5
            y = y - x; //у минус х дает отрицательное значение х 3-5=-2
            y = 0 - y; //минус на минус дает плюс 0-(-2)=2
            x = x - y; //от суммы переменных отнимаем текущее значение y, то, что осталось, достается уже Х 5 - 2 = 3
            Console.WriteLine($"x = {x} y = {y}");
            Console.ReadLine();
        }

        private static int takeNumInt()
        {
            
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
