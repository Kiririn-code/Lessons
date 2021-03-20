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
        private static Random _random;

        public WorkStation()
        {
            _money = 10000;
            _clients = new Queue<Client>();
            _details = new List<Detail>();
            _random = new Random();

            for (int i = 0; i < 10; i++)
            {
                _clients.Enqueue(new Client());
            }

            for (int i = 0; i < 20; i++)
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
                Console.WriteLine($"Кажется у нас гости. Неисправность клиента - {currentClient.TypeOfBreaking}");

                for (int i = 0; i < _details.Count; i++)
                {
                    if(_details[i].Name == currentClient.TypeOfBreaking)
                    {
                        Console.WriteLine($"Деталь под замену - {_details[i].Name}\nЦена за ремонт - {_details[i].Coast+coastOfRepair}\n");
                        _money += _details[i].Coast + coastOfRepair;
                        _details.RemoveAt(i);
                        currentClient.FixTheCar();
                        break;
                    }
                }
                if (currentClient.IsSuccessful)
                {
                    Console.WriteLine($"Ремонт успешно оплачен\nСчет мастерской пополнен\nБаланс:{_money}\n");
                }
                else
                {
                    _money -= fine;
                    Console.WriteLine($"Похоже на нашем складе нет нужной запчасти\nпридется выплатить штраф\nБаланс:{_money}\n");
                }
            }
        }
    }

    class Client
    {
        public string TypeOfBreaking { get; private set; }
        public bool IsSuccessful { get; private set; }
        private static Random _random = new Random();

        public Client()
        {
            IsSuccessful = false;
            string[] typeOfBreaking = { "Колесо", "Коробка передач", "Фара", "Двигатель", "Глушитель", "Кузов","Спидометр" };
            int index = _random.Next(typeOfBreaking.Length);
            TypeOfBreaking = typeOfBreaking[index];
        }

        public void FixTheCar()
        {
            IsSuccessful = true;
        }
    }

    class Detail
    {
        public int Coast { get; private set; }
        public string Name { get; private set; }

        private static Random _random = new Random();

        public Detail()
        { 
            string[] baseOfName = { "Колесо", "Кузов", "Капот", "Двигатель", "Фара", "Глушитель", "Коробка передач" };
            int index = _random.Next(baseOfName.Length);
            int[] baseOfCoast = { 1000, 5000, 2666, 9999, 700, 1600, 7800 };
            Coast = baseOfCoast[index];
            Name = baseOfName[index];
        }
    }
}
