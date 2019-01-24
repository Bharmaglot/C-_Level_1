using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.

            Console.WriteLine("Здравствуйте. Добро пожаловать в небольшую анкету. Просим вас немного рассказать о себе, заполнив следующие вопросы:");
            Console.Write("Для начала, пожалуйста, укажите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Хорошо, {name}, сообщите, пожалуйста, вашу фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Значит {0}? Звучит неплохо! А какой у вас рост? Хотя бы примерно, в сантиметрах?", surname);
            double growth =   Convert.ToDouble(Console.ReadLine());
            if(growth < 100)
            {
                Console.WriteLine("Вы указали в сантиметрах? Это точно не ваш вес?");  
            }
            Console.WriteLine("Вас поняли. Ну, все в этом мире относительно. А какой у вас вес?");
            double mass = Convert.ToDouble(Console.ReadLine());
            double SuncusEtruscus = mass * 750;
            Console.WriteLine("Ясно. Кстати, " + SuncusEtruscus + ". Именно столько многозубок нужно, чтобы сравниться с вами по весу. Причем, достаточно упитанных!");//Вики заявлет вес от 1 до 1.5 грамма)
            Console.WriteLine("И так, что мы узнали о вас?\nВас зовут " + name + ", по фамилии " + surname + ". Рост составляет " + growth + ", и это при весе в " + mass + ".");
            Console.WriteLine($"Так и запишем. {name} {surname}, рост {growth}, вес{mass}.");
            Console.WriteLine("Интересно, {0} {1}, история и запомнит вас при росте {2} и весе {3}? Будем посмотреть. Всего вам доброго!", name, surname, growth, mass);



            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле / k’I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.



            double iMT = mass / ((growth/100) * (growth/100));
            Console.WriteLine($"/n/n/nКстати, ваш индекс массы тела {iMT}");
            Console.ReadLine();
        }
    }
}
