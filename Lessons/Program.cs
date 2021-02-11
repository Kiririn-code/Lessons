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
            bool isPrograRun = true;
            List<string> personJob = new List<string>();
            List<string> personData = new List<string>();

            while (isPrograRun)
            {
                userChoise = Console.ReadLine();
                Console.WriteLine("Чтобы добавить данные введите - add");
                Console.WriteLine("Чтобы удалить данные введите - remove");
                Console.WriteLine("Чтобы отобразить данные введите - show");
                Console.WriteLine("Чтобы выйти из программы введите - exit");

                switch(userChoise)
                {
                    case "exit":
                        isPrograRun = false;
                        Console.WriteLine("Работа завершена");
                        break;
                    case "remove":
                        DeleteData(ref personJob, ref personData);
                        break;
                    case "add":
                        AddList(ref personJob,ref personData);
                        break;
                    case "show":
                        ShowList(personJob,personData);
                        break;
                    default:
                        Console.WriteLine("Команда не распознанна");
                        break;
                }
            }
        }

        static void AddList(ref List<string> personJob, ref List<string> personData)
        {
            Console.Write("Введите данные пользователя: ");
            personData.Add(Console.ReadLine());
            Console.Write("Введите место работы: ");
            personJob.Add(Console.ReadLine());
        }

        static void ShowList(List<string> personJob, List<string> personData)
        {
            for (int i = 0; i < personData.Count; i++)
            {
                Console.WriteLine($"{i+1} - ФИО - {personData[i]} Место работы - {personJob[i]}");
            }
        }
        static void DeleteData(ref List<string> personJob, ref List<string> personData)
        {
            Console.Write("Введите номер ячейки ктороую хотите удалить: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            personData.RemoveAt(index);
        }
    }
}
