using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbIRobi
{
    //Владимир Болбат. Задание 3. 3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
    //Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса. 
      

    //Не выполнено: ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
    //ArgumentException("Знаменатель не может быть равен 0");
    //Добавить упрощение дробей.
    class fractions
    {
        int nom;
        int denom;
        public fractions()
        {
            nom = 0;
            denom = 0;
        }
        public fractions(int _nom, int denom)
        {
            nom = _nom;
            this.denom = denom;
            if (denom == 0)
            {
                Console.WriteLine("На ноль мы пока не делим");
                while (true)
                {
                    denom = denom + 1 - 1;
                }
                //временная мера блокировки при делении на 0
            }
        }

        public int Denom
        {
            get { return denom; }
            set
            {

                if (value != 0)
                {
                    denom = value;
                }
            }

        }

        public string ToMyString()
        {
            return nom + "/" + denom;
        }

        public fractions Plus(fractions x2)
        {
            fractions x3 = new fractions();
            x3.nom = nom * x2.Denom + x2.nom * Denom;
            x3.Denom = x2.Denom * Denom;
            return x3;
        }

        public fractions Diff(fractions x2)
        {
            fractions x3 = new fractions();
            x3.nom = nom * x2.Denom - x2.nom * Denom;
            x3.Denom = x2.Denom * Denom;
            return x3;
        }

        public fractions Multi(fractions x2)
        {
            fractions x3 = new fractions();
            x3.nom = x2.nom * nom;
            x3.Denom = x2.Denom * Denom;
            return x3;
        }

        public fractions Diviz(fractions x2)
        {
            fractions x3 = new fractions();
            x3.nom = nom * x2.Denom;
            x3.Denom = Denom * x2.nom;
            return x3;
        }


    }


    class Program
    {
        //по выводу сообщений - в таком виде, просто уже не успеваю разбить на сообщения, с заполнением постепенным дробей и уникальными строчками для запроса каждой переменной.
        static string messageTrue = "заполняем значение A / B";
        static string messageFalse = "Введенное вами значение не является числом, пожалуйста, будьте внимательнее.\nВведите любое целое. ";

        static int checkMessage(string mess)
        {

            int x;
            string s;
            bool flag = true;
            do
            {
                if (flag == true)
                {
                    Console.WriteLine(messageTrue);

                }
                else
                {
                    Console.WriteLine(messageFalse);
                }
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);
            }
            while (!flag);
            return x;
        }



        static void Main(string[] args)
        {
            fractions result;
            int userNom = checkMessage(messageTrue);
            int userDenom = checkMessage(messageTrue);
            fractions fractions1;
            fractions1 = new fractions(userNom, userDenom);
            Console.WriteLine("Значение первой дроби: " + fractions1.ToMyString());
            userNom = checkMessage(messageTrue);
            userDenom = checkMessage(messageTrue);
            fractions fractions2 = new fractions(userNom, userDenom);
            Console.WriteLine("Значение первой дроби: " + fractions2.ToMyString());
            result = fractions1.Plus(fractions2);
            Console.WriteLine("при сложении мы получим: " + result.ToMyString());
            result = fractions1.Diff(fractions2);
            Console.WriteLine("при умножении мы получим: " + result.ToMyString());
            result = fractions1.Multi(fractions2);
            Console.WriteLine("Отнимая вторую дробь от первой мы получим: " + result.ToMyString());
            result = fractions1.Diviz(fractions2);
            Console.WriteLine("Поделив первую дробь на вторую мы получим: " + result.ToMyString());
            Console.ReadKey();
        }
    }
}
