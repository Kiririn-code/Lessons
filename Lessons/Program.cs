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
            bool isProgramRun = true;
            string userWord;

            Dictionary<string, string> vocabulary = new Dictionary<string, string>();
            vocabulary.Add("падера", "Сильный ветер с дождем или снегом");
            vocabulary.Add("цикада", "Прыгающие насекомые с выпуклыми глазами");
            vocabulary.Add("сабо", "Деревяннй башмак");
            vocabulary.Add("каган", "титул главы государства у древних тюркских народов");


            while (isProgramRun)
            {
                Console.WriteLine("Чтобы выйти из программы введите - exit");
                Console.WriteLine("Введите слово для проверки: ");
                userWord = Console.ReadLine().ToLower();
                switch (userWord)
                {
                    case "exit":
                        isProgramRun = false;
                        break;
                    default:
                        if (vocabulary.ContainsKey(userWord))
                            Console.WriteLine($"{userWord} - это {vocabulary[userWord]}");
                        else
                            Console.WriteLine($"Cлово {userWord} отсутствует в нашем толковом словаре");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}
