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
            string userChoise;
            bool isProgramRun = true;
            Dictionary<string, string> personData = new Dictionary<string, string>();

            while (isProgramRun)
            {
                userChoise = Console.ReadLine();
                Console.WriteLine("Чтобы добавить данные введите - add");
                Console.WriteLine("Чтобы удалить данные введите - remove");
                Console.WriteLine("Чтобы отобразить данные введите - show");
                Console.WriteLine("Чтобы выйти из программы введите - exit");

                switch(userChoise)
                {
                    case "exit":
                        isProgramRun = false;
                        Console.WriteLine("Работа завершена");
                        break;
                    case "remove":
                        DeleteData(personData);
                        break;
                    case "add":
                        AddLists(personData);
                        break;
                    case "show":
                        ShowInfo(personData);
                        break;
                    default:
                        Console.WriteLine("Команда не распознанна");
                        break;
                }
            }
        }

        static void AddLists(Dictionary<string,string> personData)
        {
            Console.WriteLine("Введите данные пользователя: ");
            Console.Write("Фамилия Имя Отчество - ");
            string personName = Console.ReadLine();
            Console.Write("Метсо работы - ");
            string personJob = Console.ReadLine();
            personData.Add(personName, personJob);
        }

        static void ShowInfo(Dictionary<string,string> personData)
        {
            foreach (var item in personData)
            {
                Console.WriteLine($"ФИО - {item.Key} место работы - {item.Value}");
            }
        }
        static void DeleteData(Dictionary<string,string> personData)
        {
            Console.Write("Введите ФИО человека,которого хотите удалить:  ");
            string person = Console.ReadLine();
            if(personData.ContainsKey(person))
            {
                personData.Remove(person);
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
