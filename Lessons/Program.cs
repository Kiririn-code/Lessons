using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoise = "";
            string userPassword = "";
            bool userOutput = true;
                Console.WriteLine("Добрый День,вы находитесь в главном меню,чтобы: ");
                Console.WriteLine("Чтобы устаноить пароль введите - setpasswd");
                Console.WriteLine("Чтобы изменить цвет консоли введите - changecolor");
                Console.WriteLine("Чтобы вывести список команд введите  - help");
                Console.WriteLine("Чтобы выйти из программы введите - exit");
                Console.WriteLine("Чтобы узнать дату введите  - time");
            while (userOutput)
            {
                userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case ("setpasswd"):
                        Console.Clear();
                        Console.Write("Введите новый пароль: ");
                        userPassword = Console.ReadLine();
                        Console.WriteLine("Новый пароль: " + userPassword);
                        break;
                    case ("changecolor"):
                        Console.Clear();
                        Console.Write("Чтобы изменить цвет консоли введите пароль: ");
                        string userInput = Console.ReadLine();
                        if (userInput !=userPassword ||userPassword == "")
                        {
                            Console.WriteLine("Пароль не верный,либо пароль не установлен");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                            break;
                    case ("help"):
                        Console.Clear();
                        Console.WriteLine("Чтобы устаноить пароль,введите setpasswd");
                        Console.WriteLine("Чтобы изменить цвет консоли введите - changecolor");
                        Console.WriteLine("Чтобы вывести список команд введите  - help");
                        Console.WriteLine("Чтобы выйти из программы введите - exit");
                        break;
                    case ("exit"):
                        Console.Clear();
                        Console.WriteLine("Вы уверены,что хотите выйти из программы - Y/N");
                        string userAnswer = Console.ReadLine();
                        if (userAnswer =="y" ||userAnswer =="Y")
                        {
                            userOutput = false;
                        }
                        break;
                    case ("time"):
                        Console.Clear();
                        Console.WriteLine("Сегодня: " + DateTime.Today);
                        break;
                }
            }
            Console.WriteLine("Всего ХО-РО-ШЕ-ГО");
        }
    }
}
