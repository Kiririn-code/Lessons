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

            Console.WriteLine("ВВедите количество жизней");
            int health = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество брони ");
            int armor = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество урона");
            int damage = int.Parse(Console.ReadLine());
            var result = getDamage(health, armor, damage);
            Console.WriteLine($"Вы получили {result} урона");
            if(result>=health)
                Console.WriteLine("Вы погибли");
            else Console.WriteLine($"У Вас осталось {health-result} жизней");

       }
        public static float getDamage(int Health, int Armor, int Damage)
        {
            float lostHealth = Damage/100f * Armor;
            return lostHealth;
        }
    }
}
