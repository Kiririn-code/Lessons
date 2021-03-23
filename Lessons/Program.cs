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
        private Random _random;

        public WorkStation()
        {
            _money = 5000;
            _clients = new Queue<Client>();
            _details = new List<Detail>();
            _random = new Random();
            string[] baseOfName = { "Колесо", "Кузов", "Капот", "Двигатель", "Фара", "Глушитель", "Коробка передач" };
            int[] baseOfCoast = { 1000, 5000, 2666, 9999, 700, 1600, 7800 };


            for (int i = 0; i < 100; i++)
            {
                int detail = _random.Next(baseOfName.Length);
                _clients.Enqueue(new Client(baseOfName[detail]));
            }

            for (int i = 0; i < 200; i++)
            {
                int detail = _random.Next(baseOfName.Length);
                _details.Add(new Detail(baseOfCoast[detail], baseOfName[detail]));
            }
        }

        public void DoWork()
        {
            int fine = 5000;
            int coastOfRepair = 2000;

            while(_clients.Count > 0)
            {
                Random random = new Random();
                var currentClient = _clients.Dequeue();
                Console.WriteLine($"Кажется у нас гости. Неисправность клиента - {currentClient.TypeOfBreaking}");

                for (int i = 0; i < _details.Count; i++)
                {
                    if(_details[i].Name == currentClient.TypeOfBreaking)
                    {
                        // Console.WriteLine($"Деталь под замену - {_details[i].Name}\nЦена за ремонт - {_details[i].Coast+coastOfRepair}\n");
                        if (random.Next(6) == 0)
                        {
                            if (_details[i].Name != _details[i + 1].Name)
                            {
                                Console.WriteLine($"Деталь под замену - {_details[i + 1].Name}\nЦена за ремонт - {_details[i].Coast + coastOfRepair}\n");
                                _details.RemoveAt(i + 1);
                                currentClient.DoFault();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Деталь под замену - {_details[i].Name}\nЦена за ремонт - {_details[i].Coast + coastOfRepair}\n");
                            _money += _details[i].Coast + coastOfRepair;
                            _details.RemoveAt(i);
                            currentClient.FixTheCar();
                        }
                        break;
                    }
                }
                if (currentClient.IsSuccessful)
                {
                    Console.WriteLine($"Ремонт успешно оплачен\nСчет мастерской пополнен\nБаланс:{_money}\n");
                }
                else if (currentClient.IsFault)
                {
                    _money -= fine;
                    Console.WriteLine($"О, нет, кажется мы заменили не ту деталь, придется возместить убытки\nБаланс:{_money}\n");
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
        public bool IsFault { get; private set; }

        public Client(string tupeOfBreacing)
        {
            IsSuccessful = false;
            
            TypeOfBreaking = tupeOfBreacing;
        }

        public void FixTheCar()
        {
            IsSuccessful = true;
        }

        public void DoFault()
        {
            IsFault = true;
        }
    }

    class Detail
    {
        public int Coast { get; private set; }
        public string Name { get; private set; }

        public Detail(int coast, string name)
        { 
            Coast = coast;
            Name = name;
        }
    }
}
