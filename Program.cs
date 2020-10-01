using System;

namespace MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Square square1 = new Square(false);
            Square square2 = new Square(true);

            square1.IncrementCloseMineCount();
            square1.TrySweep();

            Console.WriteLine(square1.Symbol);
            Console.WriteLine(square2.Symbol);
            */

            Board board = new Board(args);
            board.Print();
        }
    }
}
