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
           
        }
    }

    abstract class Human
    {
        protected string Name;
        protected float Health;
        protected float Damage;

        public Human(string name,float health,float damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public float GetDamage(float damage)
        {
            return Health -= damage;
        }

    }

    class Berserk: Human
    {
        public Berserk(string name,float health,float damage): base(name, health, damage) { }
    }

    class Warlock: Human
    {
        private bool _isDemonSummon;
        public Warlock(string name, float health, float damage) : base(name, health, damage) { }

        public void SummonDemon()
        {
            if(_isDemonSummon == false)
            {

            }
        }
    }

    class Priest: Human
    {
        public Priest(string name, float health, float damage) : base(name, health, damage) { }
    }

    class Druid: Human
    {
        public Druid(string name, float health, float damage) : base(name, health, damage) { }
    }

    class Begar: Human
    {
        public Begar(string name, float health, float damage) : base(name, health, damage) { }
    }

}
