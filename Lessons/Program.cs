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
            string userChoise = " ";
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
                userChoise = Console.ReadLine();
                switch (userChoise.ToLower())
                {
                    case "добавить":
                        AddPerson(ref post, ref personalData);
                        break;
                    case "отобразить":
                        WatchData(personalData, post);
                        break;
                    case "удалить":
                        DeleteData(ref personalData, ref post);
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

        static void AddPerson(ref string[] post, ref string[] personalData)
        {
            Console.Write("Введите место работы: ");
            ExpandArray(ref post);
            Console.Write("Введите Фамилию имя отчество: ");
            ExpandArray(ref personalData);
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
            ReduceArray(ref personalData, dataNumber);
            ReduceArray(ref post, dataNumber);
        }

        static void WatchData(string[] personalData, string[] post)
        {
            for (int i = 0; i < personalData.Length; i++)
            {
                Console.WriteLine($"{i+1} - ФИО - {personalData[i]} Место работы - {post[i]}");
            }
        }

        static void ExpandArray(ref string[] array)
        {
            string[] tempArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[tempArray.Length - 1] = Console.ReadLine();
            array = tempArray;
        }

        static void ReduceArray(ref string[] array, int dataNumber)
        {
            string[] tempArray = new string[array.Length - 1];

            for (int i = 0; i <tempArray.Length; i++)
            {
                if(i<dataNumber)
                {
                    tempArray[i] = array[i];
                }
                else
                {
                    tempArray[i] = array[i + 1];
                }
            }
            array = tempArray;
        }
    }
}
