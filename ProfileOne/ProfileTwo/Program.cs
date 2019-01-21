using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            
           // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
           // б) *Сделать задание, только вывод организовать в центре экрана.
           // в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).

            
            string sity = "Красноярск";
            string name = "Владимир";
            string surname = "Болбат";
            int ConsPositionХ = 50;
            int ConsPositionY = 15;

            ProfileToCentr(sity, name, surname, ConsPositionХ, ConsPositionY);
            Console.ReadLine();
        }

        

        private static void ProfileToCentr(string sity, string name, string surname, int ConsPositionХ, int ConsPositionY)
        {
            Console.SetCursorPosition(ConsPositionХ, ConsPositionY);
            Console.WriteLine($"{name} {surname}. {sity}");
        }
    }
}
