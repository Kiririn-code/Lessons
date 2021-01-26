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
            bool isProgramExit = true;
            while (isProgramExit)
            {
                Console.WriteLine("Добрый День,вы находитесь в главном меню,чтобы: ");
                Console.WriteLine("Чтобы установить пароль введите - setpasswd");
                Console.WriteLine("Чтобы изменить цвет консоли введите - changecolor");
                Console.WriteLine("Чтобы вывести список команд введите  - help");
                Console.WriteLine("Чтобы выйти из программы введите - exit");
                Console.WriteLine("Чтобы узнать дату введите - time");

                userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case ("setpasswd"):
                        Console.Write("Введите новый пароль: ");
                        userPassword = Console.ReadLine();
                        Console.WriteLine("Новый пароль: " + userPassword);
                        Console.Clear();
                        break;
                    case ("changecolor"):;
                        Console.Write("Чтобы изменить цвет консоли введите пароль: ");
                        string userInput = Console.ReadLine();
                        if (userInput !=userPassword ||userPassword == "")
                        {
                            Console.WriteLine("Пароль не верный,либо пароль не установлен");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        Console.Clear();
                    break;
                    case ("help"):
                        Console.WriteLine("Чтобы устанвить пароль введите - setpasswd");
                        Console.WriteLine("Чтобы изменить цвет консоли введите - changecolor");
                        Console.WriteLine("Чтобы вывести список команд введите  - help");
                        Console.WriteLine("Чтобы выйти из программы введите - exit");
                        Console.WriteLine("Чтобы узнать дату введите - time");
                        Console.Clear();
                        break;
                    case ("exit"):
                        Console.WriteLine("Вы уверены,что хотите выйти из программы - Y/N");
                        string userAnswer = Console.ReadLine();
                        if (userAnswer =="y" ||userAnswer =="Y")
                        {
                            isProgramExit = false;
                        }
                        Console.Clear();
                        break;
                    case ("time"):
                        Console.WriteLine("Сегодня: " + DateTime.Today);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Я не знаю такой команды,попробуйте еще раз");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            Console.WriteLine("Всего ХО-РО-ШЕ-ГО");
        }
    }
}
