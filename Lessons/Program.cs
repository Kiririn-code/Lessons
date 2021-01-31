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
            int userGold;
            int userCrystal = 0;
            int crystalRate = 30;
            bool isChangePossible;
            Console.Write("Введите количество золота: ");
            userGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Добрый день,курс золота к кристаллам =  "+crystalRate+ "\nСколько хотите приобрести? ");
            userCrystal = Convert.ToInt32(Console.ReadLine());
            isChangePossible = userCrystal * crystalRate <= userGold;
            int changeFactor = Convert.ToInt32(isChangePossible);
            userCrystal *= changeFactor;
            userGold -= crystalRate * userCrystal * changeFactor;
            Console.WriteLine("У вас - " + userCrystal + " кристалов и "+ userGold + " золота");
        }
    }
}
