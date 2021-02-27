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

            int firstHeroID;
            int secondHeroID;
            Random random = new Random();
            List<Human> humans = new List<Human>();
            humans.Add(new Berserk("Swarog", 240, 80,50));
            humans.Add(new Warlock("Guldan", 250, 100,0));
            humans.Add(new Priest("Alfred", 230, 50,100));
            humans.Add(new Assasin("Floyd", 160, 100,1));
            humans.Add(new Begar("Vasil", 1, 1));

            foreach (var player in humans)
            {
               player.ShowStats();
            }
            Console.WriteLine("Выберете 1 бойца");
            firstHeroID = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберете 2 бойца");
            secondHeroID = int.Parse(Console.ReadLine());

            if (firstHeroID == secondHeroID)
            {
                Console.WriteLine("Не возможно выбрать 2 одинаковых персонажей");
            }
            else
            {
                Human firstHero = humans[firstHeroID];
                Human secondHero = humans[secondHeroID];

                while (firstHero.Health > 0 && secondHero.Health > 0)
                {
                    Console.WriteLine("Выберите тип атаки");
                    Console.WriteLine("1 - специальная атака, свойственная классу");
                    Console.WriteLine("2 - обычная атака");

                    if (int.TryParse(Console.ReadLine(), out int value) && value == 1)
                        firstHero.DoSpecialAttack();
                    else
                        Console.WriteLine("Обычная атака");

                    if (random.Next(2) == 1)
                        secondHero.DoSpecialAttack();

                    firstHero.GetDamage(secondHero.ReturnDamage());
                    secondHero.GetDamage(firstHero.ReturnDamage());
                    firstHero.ShowStats();
                    secondHero.ShowStats();
                }
            }
        }
    }

   abstract class Human
    {
        protected string Name;
        public float Health { get; protected set; }
        protected float Damage;
        protected Random Random;

        public Human(string name,float health,float damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Random = new Random();
        }

        public abstract void DoSpecialAttack();

        public float GetDamage(float damage)
        {
            return Health -= damage;
        }
        public float ReturnDamage()
        {
            return Damage;
        }
        
        public void ShowStats()
        {
            Console.WriteLine($"{Name} имеет {Health} жизней и {Damage} атаки");
        }

    }

    class Berserk: Human
    {
        private int _armor;
        public Berserk(string name,float health,float damage, int armor): base(name, health, damage) 
        {
            _armor = armor;
        }

        public override void DoSpecialAttack()
        {
            Console.WriteLine("Поднять щиты: герой получает 10 дополнительных едениц брони");
            Health += _armor;            
        }
    }

    class Warlock: Human
    {
        private int _bloodPoint;
        public Warlock(string name, float health, float damage, int bloodPoint) : base(name, health, damage)
        {
            _bloodPoint = bloodPoint;
        }
        public override void DoSpecialAttack()
        {
            Console.WriteLine("Открытая рана: жертвует частью своего здоровья, чтобы увеличить силу");
            if(Health>=20)
            {
                Health -= 9;
                _bloodPoint += 20;
                Damage += 40;
            }
            if(_bloodPoint==100)
            {
                Health = 0;
            }
        }

    }

    class Priest: Human
    {
        private int _manaPoint;
        public Priest(string name, float health, float damage,int manaPoint) : base(name, health, damage)
        {
            _manaPoint = manaPoint;
        }

        public override void DoSpecialAttack()
        {
            Console.WriteLine("Возложение рук: восстанавливает от 10 до 25 едениц здоровья за 25 маны");
            if (Health <= 230 && _manaPoint >= 25)
            {
                Health = Random.Next(10, 25);
                _manaPoint -= 25;
            }
        }

    }

    class Assasin: Human
    {
        private float _accuracy;
        public Assasin(string name, float health, float damage, float accuracy) : base(name, health, damage)
        {
            _accuracy = accuracy;
        }

        public override void DoSpecialAttack()
        {
            Damage = 100;
            Console.WriteLine("Удар в спину: убийца наносит серию ударов по противнику c 50% точностью");
            for (int i = 0; i < Random.Next(6); i++)
            {
                Damage += 10 * (_accuracy/2);
            }
        }
    }

    class Begar: Human
    {

        public Begar(string name, float health, float damage) : base(name, health, damage) { }

        public override void DoSpecialAttack()
        {
            Console.WriteLine("Радость бедняка: персонажу выдается случайный набот характеристик");
            Health = Random.Next(300);
            Damage = Random.Next(100);
        }

    }

}
