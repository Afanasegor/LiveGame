using System;
using Live;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);

            GameEngine gameEngine = new GameEngine
                (
                    rows: 100,
                    cols: 300,
                    density: 2
                );

            while (true)
            {
                Console.Title = gameEngine.CurrentGeneration.ToString();

                bool[,] field = gameEngine.GetCurrentGeneration();

                for (int y = 0; y < field.GetLength(1); y++)
                {
                    char[] str = new char[field.GetLength(0)];
                    for (int x = 0; x < field.GetLength(0); x++)
                    {
                        if (field[x, y])
                            str[x] = '#';
                        else
                            str[x] = ' ';
                    }
                    Console.WriteLine(str);
                }
                Console.SetCursorPosition(0,0);
                gameEngine.NextGeneration();
            }
        }
    }
}
