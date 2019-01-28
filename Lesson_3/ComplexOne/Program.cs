using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexOne
{
    class Complex
    {
        //Задание 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры; Владимир Болбат.
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

        //деление. Сначала сделал, потом понял, что не нужно. Но решил оставить - может в будущем пригодится.
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


        // Для примера ограничимся только положительными числами. (из задания). 
        //Убирать не стал, так так задание было доработать текущий проект, однако, методы вычисления комплексных могут работать и с отрицательными числами.
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
            Complex complex1;
            complex1 = new Complex(1, 1);
            Complex complex2 = new Complex(2, 2);
            Complex result;

            result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Diff(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Diviz(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
