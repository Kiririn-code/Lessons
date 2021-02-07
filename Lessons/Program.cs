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
            string userCoise = " ";
            bool isProgramRun = true;
            string[] post = new string[0];
            string[] personalData = new string[0];

            while (isProgramRun)
            {
                Console.WriteLine("Список комманд:");
                Console.WriteLine("Добавить - добавить новый элемент");
                Console.WriteLine("Отобразить - список сотрудников");
                Console.WriteLine("Удалить - удалить сотрудника из базы");
                Console.WriteLine("Найти - поиск сотрудника по фамилии");
                Console.WriteLine("Выход - выйти из программы");
                Console.Write("Введите комманду: ");
                userCoise = Console.ReadLine();
                switch (userCoise.ToLower())
                {
                    case "добавить":
                        AddPerson(ref post, ref personalData);
                        break;
                    case "отобразить":
                        WatchData(personalData, post);
                        break;
                    case "удалить":
                        DeleteData(ref post, ref personalData);
                        break;
                    case "найти":
                        FindData(personalData);
                        break;
                    case "выход":
                        isProgramRun = false;
                        break;
                    default:
                        Console.WriteLine("Комманда не обнаружена,повторите попытку");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void AddPerson(ref string[] post,ref  string[] personalData)
        {
            Console.Write("Введите данные сотрудника ");
            string[] tempPersonalData = new string[personalData.Length + 1];

            for (int i = 0; i < personalData.Length; i++)
            {
                tempPersonalData[i] = personalData[i];
            }
            tempPersonalData[tempPersonalData.Length - 1] = Console.ReadLine();
            personalData = tempPersonalData;

            Console.Write("Введите место работы ");
            string[] tempPost = new string[(post.Length + 1)];

            for (int i = 0; i < post.Length; i++)
            {
                tempPost[i] = post[i];
            }
            tempPost[tempPost.Length - 1] = Console.ReadLine();
            post = tempPost;
        }

        static void FindData(string[] personalData)
        {
            Console.Write("Введите фамилию сотрудника ");
            string surname = Console.ReadLine();

            for (int i = 0; i < personalData.Length; i++)
            {
                if (personalData[i].ToLower().Contains(surname))
                {
                    Console.WriteLine($"Сотрудник найден прод номером {i + 1}");
                }
            }
        }

        static void DeleteData(ref string[] personalData, ref string[] post)
        {
            Console.Write("Введите номер ячейки,котороую хотите удалить: ");
            int dataNumber = int.Parse(Console.ReadLine()) - 1;
            for (int i = 0; i <personalData.Length ; i++)
            {
                if(i==dataNumber)
                {
                    personalData[i] = null;
                    post[i] = null;
                }
            }
        }

        static void WatchData(string[] personalData, string[] post)
        {
            for (int i = 0; i < personalData.Length; i++)
            {
                Console.WriteLine($"{i+1} - ФИО - {personalData[i]} Место работы - {post[i]}");
            }
        }
    }
}
