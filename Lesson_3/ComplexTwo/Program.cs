using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTwo
{
    //Задание 1. б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса; + задание из методички. Владимир Болбат.
    class Complex
    { 
        private double im;
        double re;


        public Complex()
        {
            im = 0;
            re = 0;
        }


        public Complex(double _im, double re)
        {              
            im = _im;
            this.re = re;
        }


    /// <summary>
    /// Метод сложения комплексных чисел, используемый в примере задания урока 3.
    /// </summary>
    /// <param name="x2">аргумент функции сложения</param>
    /// <returns>Результат сложения комплексных чисел</returns>
    public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

    /// <summary>
    /// Метод вычитания второго заданного комплексного числа из первого заданного комплексного числа
    /// </summary>
    /// <param name="x2">аргумент функции сложения</param>
    /// <returns>Результат вычитания комплексных чисел</returns>
    public Complex Diff(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

    /// <summary>
    /// Метод произведения комплексных чисел
    /// </summary>
    /// <param name="x2">аргумент функции произведения</param>
    /// <returns>Результат произведения комплексных чисел</returns>
    public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

    /// <summary>
    /// Метод деления первого заданного комплекстого числа на второе заданное комплексное число
    /// </summary>
    /// <param name="x2">аргумент функции деления</param>
    /// <returns>Результат деления комплексных чисел</returns>
    public Complex Diviz(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = (re * x2.re + im * x2.im) / (x2.re * x2.re + x2.im * x2.im);
            x3.im = (im * x2.re - re * x2.im) / (x2.re * x2.re + x2.im * x2.im);
            return x3;
        }

        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }
    /// <summary>
    /// Метод взятый из методички, задания на доработку: метод, который возвращает строковое представление данных.
    /// </summary>
    /// <returns>результат в ввиде комплексного числа для пользователя</returns>
    public string ToString()
        {
            return re + "+" + im + "i";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Здравствуйте. В данной программе вы можете провести простые рассчеты с комплексными числами." +
                "\n\nДля начала, пожалуйста, введите значение переменной А для первого комплекстного числа типа a+bi");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Теперь укажите значение переменной B для первого комплекстного числа типа {a}+bi");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"И так, первым коплексным числом является {a}+{b}i");
            Console.WriteLine("Теперь введите значение переменной А для первого комплекстного числа типа a+bi");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Теперь укажите значение переменной B для второго комплекстного числа типа {c}+bi");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"И так, первым коплексным числом является {c}+{d}i , а вторым комплексным числом является {a}+{b}i.\n\n " +
                $"Вам доступны следующие операции: \nСложение - для сложения введите цифру 1. " +
                $"\nВычитание - для вычитания введите цифру 2." +
                $"\nУмножение - для умножения введите цифру 3." +
                $"\nДеление - для деления введите цифру 4.\n для завершения работы программы введите любое иное значение");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());


            Complex complex1;
            complex1 = new Complex(a, b);
            Complex complex2 = new Complex(2, 2);
            Complex result;



            //Задание из методички.
            switch (caseSwitch)
            {
                case 1:
                    result = complex1.Plus(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case 2:
                    result = complex1.Diff(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case 3:
                    result = complex1.Multi(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                case 4:
                    result = complex1.Diviz(complex2);
                    Console.WriteLine(result.ToString());
                    break;
                default:
                    Console.WriteLine("Всего вам доброго");
                    break;
            }
            Console.ReadKey();
        }
    }
}
