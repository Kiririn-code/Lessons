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
            WorkStation workStation = new WorkStation();
            workStation.DoWork();
        }
    }

    class WorkStation
    {
       private Queue<Client> _clients;
       private List<Detail> _details;
        private int _money;

        public WorkStation()
        {
            _money = 10000;
            _clients = new Queue<Client>();
            _details = new List<Detail>();

            for (int i = 0; i < 100; i++)
            {
                _clients.Enqueue(new Client());
            }

            for (int i = 0; i < 700; i++)
            {
                _details.Add(new Detail());
            }
        }

        public void DoWork()
        {
            int fine = 1000;
            int coastOfRepair = 2000;

            while(_clients.Count > 0)
            {
                var currentClient = _clients.Dequeue();

                for (int i = 0; i < _details.Count; i++)
                {
                    if(_details[i].Name == currentClient.TypeOfBreaking)
                    {
                        Console.WriteLine($"Неисправность - {currentClient.TypeOfBreaking}\nЦена зп ремонт - {_details[i].Coast+coastOfRepair}");
                        _money = _details[i].Coast + coastOfRepair;
                        _details.RemoveAt(i);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Похоже у нас нет детали,чтобы отремонтировать ваш автомобиль");
                        _money -= fine;
                    }
                }
                Console.ReadLine();

            }
        }

    }

    class Client
    {
        public string TypeOfBreaking { get; private set; }
        private static Random _random = new Random();

        public Client()
        {
            string[] typeOfBreaking = { "Колесо", "Коробка передач", "Фара", "Двигатель", "Глушитель", "Кузов","Спидометр" };
            TypeOfBreaking = typeOfBreaking[_random.Next(6)];
        }
    }

    class Detail
    {
        public int Coast { get; private set; }
        public string Name { get; private set; }
        private static Random _random;

        public Detail()
        {
            string[] baseOfName = { "Колесо", "Кузов", "Капот", "Двигатель", "Фара", "Глушитель", "Коробка передач" };
            int[] baseOfCoast = { 1000, 5000, 2666, 9999, 700, 1600, 7800 };
            int index;
            _random = new Random();
            index = _random.Next(7);
            Coast = baseOfCoast[index];
            Name = baseOfName[index];
        }
    }
}
