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
            string firstName = "";
            string lastName = "";
            string zodiacSign = "";
            int age = 0;
            string placeOfWork = "";

            Console.Write("Добрый день, введите ваше имя: ");
            firstName = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            lastName = Console.ReadLine();
            Console.Write("Количество полных лет: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ваш знак зодиака: ");
            zodiacSign = Console.ReadLine();
            Console.Write("Место Вашей работы: ");
            placeOfWork = Console.ReadLine();

            Console.WriteLine("Вас зовут "+firstName+" "+lastName+", Вам "+age+" лет, Ваш знак зодиака "+ zodiacSign+" и вы работаете на "+ placeOfWork);
            Console.ReadKey();
        }
    }
}
