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
            Aquarium aquarium = new Aquarium();
            bool isProgramRun = true;

            while (isProgramRun)
            {
                Console.WriteLine("What are your doing?");
                Console.WriteLine("Add - add a new fish");
                Console.WriteLine("kind - kind a fish");
                Console.WriteLine("exit - close the program");
                string userChoise = Console.ReadLine();
                switch(userChoise)
                {
                    case "add":
                        aquarium.AddFishs();
                        Console.WriteLine("new fish is added");
                        break;
                    case "exit":
                        isProgramRun = false;
                        break;
                    case "kind":
                        Console.Write("What kind of fish should you catch: ");
                        string nameFish = Console.ReadLine();
                        aquarium.RemoveFishs(nameFish);
                        break;
                }
                aquarium.GrowOldFishs();
                aquarium.ShowFishs();
            }
        }
    }

}

class Aquarium
{
   private List<Fish> _fishs = new List<Fish>();

    public void AddFishs()
    {
        Console.Write("name: ");
        string fishName = Console.ReadLine();
        Console.Write("Age: ");
        int fishAge = int.Parse(Console.ReadLine());
        Console.Write("Number of years: ");
        int numberOfYears = int.Parse(Console.ReadLine());
        _fishs.Add(new Fish(fishName, fishAge,numberOfYears));
    }

    public void ShowFishs()
    {
        Console.Clear();
        foreach (var fish in _fishs)
        {
            Console.WriteLine($"Fish name: {fish.Name}\nfish age: {fish.Age}");
            Console.WriteLine("-------------------");
        }
    }

    public void GrowOldFishs()
    {
        string name="";
        for (int i = 0; i < _fishs.Count; i++)
        {
            _fishs[i].GrowOld();
            if (_fishs[i].Age == _fishs[i].NumberOfYears)
            {
                Console.WriteLine("Shit, it look like your fish is dead");
                name = _fishs[i].Name;
            }
        }
        RemoveFishs(name);
    }

    public void RemoveFishs(string name)
    {
        if (TryFindIndex(out int index,name))
            _fishs.RemoveAt(index);

    }

    private bool TryFindIndex(out int index,string name)    
    {
        index = 0;
        bool isIndexFind =false;
        for (int i = 0; i < _fishs.Count; i++)
        {
             isIndexFind = _fishs[i].Name == name;
            if (isIndexFind)
            {
                index = i;
                break;
            }
        }
        return isIndexFind;
 }

}

class Fish
{
    public string Name { get; private set; }
    public int Age { get;private  set; }
    public int NumberOfYears { get;private set; }

    public Fish(string name, int age,int numberOfYears)
    {
        Name = name;
        Age = age;
        NumberOfYears = numberOfYears;
    }

    public void GrowOld()
    {
        ++Age;
    }
}