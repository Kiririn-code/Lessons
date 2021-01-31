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
            int crystalPrice = 30;
            bool isChangePossible;
            Console.Write("Введите количество золота: ");
            userGold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Добрый день,курс золота к кристаллам =  "+crystalPrice+ "\nСколько хотите приобрести? ");
            userCrystal = Convert.ToInt32(Console.ReadLine());
            isChangePossible = userCrystal * crystalPrice <= userGold;
            int changeFactor = Convert.ToInt32(isChangePossible);
            userCrystal *= changeFactor;
            userGold -= crystalPrice * userCrystal;
            Console.WriteLine("У вас - " + userCrystal + " кристалов и "+ userGold + " золота");
        }
    }
}
