using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGameRun = true;
            int playerX, playerY;
            int playerDX = 0, playerDY = 0;
            char[,] map = ReadMap("map.txt",out playerX, out playerY);
            Console.CursorVisible = false;
            DrawMap(map);

            while (isGameRun)
            {
                Console.SetCursorPosition(playerY, playerX);
                Console.Write('&');

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.W:
                            playerDX = -1;
                            playerDY = 0;
                            break;
                        case ConsoleKey.A:
                            playerDX = 0;
                            playerDY = -1;
                            break;
                        case ConsoleKey.D:
                            playerDX = 0;
                            playerDY = 1;
                            break;
                        case ConsoleKey.S:
                            playerDX = 1;
                            playerDY = 0;
                            break;
                    }

                    if (map[playerDX + playerX, playerDY + playerY] != '0')
                    {
                        Console.SetCursorPosition(playerY, playerX);
                        Console.Write(" ");

                        playerX += playerDX;
                        playerY += playerDY;

                        Console.SetCursorPosition(playerY, playerX);
                        Console.Write('&');

                    }
                }
            }
        }
        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
        static char[,] ReadMap(string mapName, out int playerX, out int playerY)
        {
            playerY = 0;
            playerX = 0;
            string[] newFile = File.ReadAllLines(mapName);
            char[,] map = new char[newFile.Length, newFile[0].Length];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = newFile[i][j];

                    if(map[i,j] =='&')
                    {
                        playerX = i;
                        playerY = j;
                    }
                }
            }
            return map;
        }
    }
}
