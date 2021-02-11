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
            string userAction;
            bool isProgramRun = true;
            List<int> intSum = new List<int>();

            Console.WriteLine("Список комманд:");
            Console.WriteLine("sum - вывести сумму элементов ранне введенного массива");
            Console.WriteLine("exit - выйти из программы");
            while (isProgramRun)
            {
                Console.Write("Введите команду: ");
                userAction = Console.ReadLine();
                switch(userAction)
                {
                    case "exit":
                        isProgramRun = false;
                        break;
                    case "sum":
                        SumList(intSum);
                        break;
                    default:
                        try
                        {
                            int newElement = int.Parse(userAction);
                            intSum.Add(newElement);
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("Вы ввели некорретктное значение");
                        }
                        break;
                }
            }
        }

        static void SumList (List<int> intSum)
        {
            int sum = 0;
            foreach (var item in intSum)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
