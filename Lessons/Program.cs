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
            string userName;
            char frameChar;
            string charLine = "";
            Console.Write("Добрый день,введите свое имя ");
            userName = Console.ReadLine();
            Console.Write("Введите символ для рамки: ");
            frameChar = Convert.ToChar(Console.ReadLine());
            for (int i = 0; i < (userName.Length+2); i++)
            {
                charLine +=Convert.ToString(frameChar);
            }
           
            Console.WriteLine(charLine+'\n'+(frameChar+userName+frameChar)+'\n'+charLine);
        }
    }
}
