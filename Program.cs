using System;

namespace MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            MineSweeper game = new MineSweeper(args);
            game.Run();
        }
    }
}
