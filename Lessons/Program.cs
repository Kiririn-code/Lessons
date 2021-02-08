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
            int playerX = 0, playerY = 0;
            int playerDX = 0, playerDY = 0;
            char[,] map = ReadMap("map.txt", ref playerX, ref playerY);
            Console.CursorVisible = false;
            DrawMap(map);

            while (isGameRun)
            {
                MovePlayer(ref playerX, ref playerY, ref playerDX, ref playerDY, ref map);
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

        static char[,] ReadMap(string mapName, ref int playerX, ref int playerY)
        {
            string[] newFile = File.ReadAllLines(mapName);
            char[,] map = new char[newFile.Length, newFile[0].Length];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = newFile[i][j];

                    if (map[i, j] == '&')
                    {
                        playerX = i;
                        playerY = j;
                    }
                }
            }
            return map;
        }

        static void MovePlayer(ref int playerX, ref int playerY, ref int playerDX, ref int playerDY, ref char[,] map)
        {
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
}
