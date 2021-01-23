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
            int picture = 52;
            int pictureStack = 3;
            int pictureLine = 0;
            int pictureOutOfLine = 0;
            pictureLine = picture / pictureStack;
            pictureOutOfLine = picture % pictureStack;
            Console.WriteLine("Из 52 картинок можно собрать " + pictureLine +" рядов по 3 картинки в ряду,после чего останется "+pictureOutOfLine + " картинка");

        }
    }
}
