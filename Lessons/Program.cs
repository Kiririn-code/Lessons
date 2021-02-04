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
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Shuffle(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Shuffle(int[] array)
        {
            Random random = new Random(); 

            for (int i = array.Length - 1; i >= 1; i--)
            {
                int tempVar;
                int tempRandom;
                tempRandom = random.Next(i);
                tempVar = array[tempRandom];
                array[tempRandom] = array[i];
                array[i] = tempVar;
            }
        }
    }
}
