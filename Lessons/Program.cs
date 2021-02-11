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
                Console.WriteLine("Введите слово для проверки: ");
                userWord = Console.ReadLine().ToLower();

                if (vocabulary.ContainsKey(userWord))
                    Console.WriteLine($"{userWord} - это {vocabulary[userWord]}");
                else
                    Console.WriteLine($"Cлово {userWord} отсутствует в нашем толковом словаре");

                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}
