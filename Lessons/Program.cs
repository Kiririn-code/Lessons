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
            string userFirstName = "";
            int userAge =0;

            while (isProgramExit)
            {
                Console.WriteLine("Добрый День,вы находитесь в главном меню,чтобы: ");
                Console.WriteLine("Чтобы установить пароль введите - setpassword");
                Console.WriteLine("Чтобы изменить цвет консоли введите - changecolor");
                Console.WriteLine("Чтобы заполнить информацию о себе введите - setinfo");
                Console.WriteLine("Чтобы выйти из программы введите - exit");
                Console.WriteLine("Чтобы узнать дату введите - time");
                Console.WriteLine("Чтобы вывести инофрмацию о себе введите - info");
                Console.WriteLine("Чтобы вывести список команд введите - help");

                userChoise = Console.ReadLine();

                Console.Clear();
                switch (userChoise)
                {
                    case ("setpassword"):
                        Console.Write("Введите новый пароль: ");
                        userPassword = Console.ReadLine();
                        Console.WriteLine("Новый пароль: " + userPassword);
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
                    break;

                    case ("setinfo"):
                        Console.Write("Введите ваше имя: ");
                        userFirstName = Console.ReadLine();
                        Console.WriteLine("Введите ваш возраст: ");
                        break;

                    case ("info"):

                        if(userAge==0 || userFirstName =="")
                        {
                            Console.WriteLine("мы ничего не знаем о Вас,простите");
                        }
                        else
                        {
                            Console.WriteLine("Вас зовут " + userFirstName + " и вам " + userAge + " лет");
                        }
                        Console.ReadKey();
                        break;

                    case ("exit"):
                            isProgramExit = false;
                        break;

                    case ("time"):
                        Console.WriteLine("Сегодня: " + DateTime.Today);
                        Console.ReadKey();
                        break;

                    case ("help"):
                        Console.WriteLine("Чтобы установить пароль введите - setpassword");
                        Console.WriteLine("Чтобы изменить цвет консоли введите - changecolor");
                        Console.WriteLine("Чтобы заполнить информацию о себе введите - setinfo");
                        Console.WriteLine("Чтобы выйти из программы введите - exit");
                        Console.WriteLine("Чтобы узнать дату введите - time");
                        Console.WriteLine("Чтобы вывести инофрмацию о себе введите - info");
                        Console.WriteLine("Чтобы вывести список команд введите - help");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Я не знаю такой команды,попробуйте еще раз");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
            Console.WriteLine("Всего ХО-РО-ШЕ-ГО");
        }
    }
}
