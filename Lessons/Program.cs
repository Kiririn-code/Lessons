using System;
using System.Collections.Generic;
using System.Linq;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new DataBase();
            dataBase.ShowOverdue();
        }
    }

    class DataBase
    {
        private List<CannedFood> _cannedFoods = new List<CannedFood>();

        public DataBase()
        {
            _cannedFoods.Add(new CannedFood(2010, 10, "Русская тушенка"));
            _cannedFoods.Add(new CannedFood(2019, 5, "Американская тушенка"));
            _cannedFoods.Add(new CannedFood(2017, 4, "Израильская тушенка"));
            _cannedFoods.Add(new CannedFood(2021, 5, "Французская тушенка"));
            _cannedFoods.Add(new CannedFood(2019, 7, "Украинская тушенка"));
        }

        public void ShowOverdue()
        {
            var overdueFood = _cannedFoods.Where(food => food.ProductionYear + food.ShelfLife <= (int)DateTime.Today.Year).ToList();

            foreach (var food in overdueFood)
            {
                Console.WriteLine(food.Name);
            }
        }
    }

    class CannedFood
    {
        public int ProductionYear { get; private set; }
        public int ShelfLife { get; private set; }
        public string Name { get; private set; }

        public CannedFood(int productionYear, int shelfLife, string name)
        {
            ProductionYear = productionYear;
            ShelfLife = shelfLife;
            Name = name;
        }
    }
}
