using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 5. Владимир Болбат.
            //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


            Console.WriteLine("Укажите ваш рост в сантиметрах");
            double growth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Укажите ваш вес в килограммах");
            double mass = Convert.ToDouble(Console.ReadLine());

            double iMT = mass / ((growth / 100) * (growth / 100));
            double maxMass = 24.99 * ((growth / 100) * (growth / 100));
            double minMass = 18.99 * ((growth / 100) * (growth / 100));
            if (iMT < 18.5)
            {
                Console.WriteLine($"Исходя из вашего индекса массы тела {iMT:0.00}, у вас недостаточный вес. Для оптимального веса, вам нужно набрать от {(minMass - mass):0.00} до {(maxMass - mass):0.00}");
            }
            else if (iMT >= 18.5 && iMT <= 24.99)
            {
                Console.WriteLine("У вас нормальный вес, индекс вашего тела составляет: {iMT:0.00}");
            }
            else
            {
                Console.WriteLine($"Исходя из вашего индекса массы тела {iMT:0.00}, у вас избыточный вес. Для оптимального веса, вам нужно скинуть от {(mass - maxMass):0.00} до {(mass - minMass):0.00}");
            }
            Console.WriteLine($"Для вашего роста оптимальный вес составляет от {minMass:0.00} кг до {maxMass:0.00} кг");
            Console.ReadLine();
        }
    }
}
