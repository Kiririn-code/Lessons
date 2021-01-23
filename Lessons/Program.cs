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
            int grannyCount = 0;
            int waitingHours = 0;
            int waitingMinute;
            int receptionTime = 10;

            Console.Write("Добрый день,введите количество старушек ");
            grannyCount = Convert.ToInt32(Console.ReadLine());
            waitingHours = (grannyCount * 10) / 60;
            waitingMinute = (grannyCount * 10) % 60;

            Console.WriteLine("Вы простоите в очереди "+waitingHours +" часа(-ов) и " + waitingMinute+" минут");



        }
    }
}
