using System;
using System.Collections.Generic;
using System.Text;

namespace MineSweeper
{
    // Typ för spelplanen i minröj.
    struct Board
    {
        private Square[,] board;
        private int flagCount, sweepedCount; 

        // Konstruktor som initaliserar en ny spelplan.
        public Board(string[] args) // Stubbe
        {
            Helper.Initialize(args);
            board = new Square[10, 10];
            for (int row = 0; row < 10; ++row)
            {
                for (int col = 0; col < 10; ++col)
                {
                    bool isBoobyTrapped = Helper.BoobyTrapped(row, col);
                    board[row, col] = new Square(isBoobyTrapped);
                }
            }

            for (int row = 0; row < 10; ++row)
            {
                for (int col = 0; col < 10; ++col)
                {
                    // för board[row, col] anropa IncrementCloseMineCount() 
                    // KORREKT antal gångar. 
                }
            }

            flagCount = 0;
            sweepedCount = 0;
        }

        // Enbart läsbar egenskap som säger som spelaren har vunnit spelet.
        public bool PlayerWon => false; // Stubbe

        // Enbart läsbar egenskap som säger om spelaren har förlorat.
        public bool GameOver => false; // Stubbe


        // Försök röja en ruta. Returnerar false om ogiltigt drag, annars true.
        public bool TrySweep(int row, int col) // Stubbe
        {
            return true;
        }

        // Försök flagga en ruta. Returnerar false om ogiltigt drag, annars true.
        public bool TryFlag(int row, int col) // Stubbe
        {
            return true;
        }

        // Skriv ut spelplanen till konsolen.
        public void Print() // Stubbe
        {
            for (int row = 0; row < 10; ++row)
            {
                for (int col = 0; col < 10; ++col)
                {
                    Console.Write(board[row, col].Symbol + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
