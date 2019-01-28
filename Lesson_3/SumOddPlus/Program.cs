using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOddPlus
{
    
// Задание 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
// Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
// б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
// При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
//Владимир Болбат

    class Program
    {
        static string messageTrue = "Введите любое целое число. Для завершения введите 0";
        static string messageFalse = "Введенное вами значение не является числом, пожалуйста, будьте внимательнее.\nВведите любое целое. Для завершения введите 0";


        /// <summary>
        /// Проверка - соответствует ли значение переменной целому числу
        /// </summary>
        /// <param name="mess">Значение получаемое из ввода консоли</param>
        /// <returns>возвращаем значение полученной переменной в числовом виде</returns>
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
            List<int> numbers = new List<int>();
            int value = 1;
            int sum = 0;

            //технически, как я понимаю, это тоже можно вынести методом. 
            //Но, если честно, я не до конца понимаю - в методы выносить нужно максимальное количество действий, а в основном коде только представлены основные переменные
            //либо это вопрос читаемости и удобства работы команды?
            while (value != 0)
            {
                value = checkMessage(messageTrue);

                if (value > 0 && (value + 1) % 2 == 0)
                {
                    sum = sum + value;
                    numbers.Add(value);
                }
            }
            Console.WriteLine("Общая сумма введенных нечетных положительных чисел, введенных вами составляет " + sum);
            Console.Write("Из введенных вами чисел, нечетными положительными являются: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($" {numbers[i]} ");
            }
            Console.ReadKey();

        }
    }
}
