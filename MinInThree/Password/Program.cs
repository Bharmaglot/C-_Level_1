using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        //Задание 4. Владимир Болбат.
        //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        //С помощью цикла do while ограничить ввод пароля тремя попытками.
        //Примечание: Проверку пароля и логина разбил на две части и два отдельных метода. Пароль на три попытки, юзер - бесконечно.
        



        //метод проверки пароля на истину или ложь
        static bool Check(string userPassword)
        {
            string TruePassword = "GeekBrains";
            if (userPassword == TruePassword) return true; else return false;
        }
        //метод проверки имени на истину или ложь
        static bool CheckName(string userName)
        {
            string TrueName = "root";
            if (userName == TrueName) return true; else return false;
        }
        //Результат проверки имени. Сделан отдельно, так как три попытки указаны только на пароль.
        private static void CheckNameResult()
        {
            while (true)
            {
                string userName = Console.ReadLine();
                if (CheckName(userName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Пользователя с таким именем в системе не обнаружено. Попробуйте еще раз");
                }

            }
        }
        //результат проверки, запасные две попытки на вход в программу далее и попадание в бесконечный цикл, в случае трех ошибок. Буддисты не одобряют.
        private static int CheckPassword(int Try)
        {
            do
            {
                string userPassword = Console.ReadLine();
                
                if (Check(userPassword))
                {
                    break;
                }
                else
                {
                    Try++;
                    Console.WriteLine("Ошибочный пароль. Осталось " + (3 - Try) + " попытк");
                }
            } while (Try < 3);
                if (Try == 3)
                {
                    Console.WriteLine("Пароль неверный, все попытки закончились. Всего вам доброго");
                    while (true)
                    {
                        Try = Try + 0;
                    }
            }
            else
            {
                Console.WriteLine("Добро пожаловать");
            }

            return Try;
        }
       
        static void Main(string[] args)
        {
            int Try = 0;
            Console.Write("Введите имя пользователя: ");
            CheckNameResult();

            Console.Write("введите пароль: ");
            Try = CheckPassword(Try);
            Console.ReadLine();
        }
    }
}
