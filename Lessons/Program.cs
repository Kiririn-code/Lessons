using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Solider[] soliders = new Solider[10];
            soliders[0] = new Solider("Иван", "Лейтенант", "Пистолет",12);
            soliders[1] = new Solider("Даниил", "Рядовой", "Пулемет",23);
            soliders[2] = new Solider("Николай", "Генерал", "Танк",33);
            soliders[3] = new Solider("Петр", "Майор", "Шашка",9);
            soliders[4] = new Solider("Сергей", "Генерал-Майор", "Граната",22);
            soliders[5] = new Solider("Григорий", "Рядовой", "Винтовка",11);
            soliders[6] = new Solider("Иннокентий", "Страшина", "Автомат",41);
            soliders[7] = new Solider("Роман", "Верховный главнокоммандующий", "Ядерное оружие",90);
            soliders[8] = new Solider("Василий", "Комбат", "БТР",21);
            soliders[9] = new Solider("Владелен", "Батяня", "Саперная лопата",7);


            var correctSoliders = from Solider solider in soliders select new { name = solider.Name, rank = solider.Rank};

            foreach (var solider in correctSoliders)
            {
                Console.WriteLine("Имя - " + solider.name + "\t Звание - " + solider.rank);
            }
        }
    }
    class Solider
    {
        public string Name { get; private set; }
        public string Rank { get; private set; }
        public string Armament { get; private set; }
        public int LifeTime { get; private set; }

        public Solider(string name, string rank, string armament, int lifeTime)
        {
            Name = name;
            Rank = rank;
            Armament = armament;
            LifeTime = lifeTime;
        }
    }
}
