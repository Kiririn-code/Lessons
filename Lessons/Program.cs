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
                int id = _random.Next(7);
                _clients.Enqueue(new Client(id));
            }

            for (int i = 0; i < 20; i++)
            {
                int id = _random.Next(7);
                _details.Add(new Detail(id));
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
                        currentClient.DoGood();
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

        public Client(int id)
        {
            IsSuccessful = false;
            string[] typeOfBreaking = { "Колесо", "Коробка передач", "Фара", "Двигатель", "Глушитель", "Кузов","Спидометр" };
            TypeOfBreaking = typeOfBreaking[id];
        }

        public void DoGood()
        {
            IsSuccessful = true;
        }
    }

    class Detail
    {
        public int Coast { get; private set; }
        public string Name { get; private set; }

        public Detail(int id)
        {
            string[] baseOfName = { "Колесо", "Кузов", "Капот", "Двигатель", "Фара", "Глушитель", "Коробка передач" };
            int[] baseOfCoast = { 1000, 5000, 2666, 9999, 700, 1600, 7800 };
            Coast = baseOfCoast[id];
            Name = baseOfName[id];
        }
    }
}
