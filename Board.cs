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
            board = null;
            flagCount = 0;
            sweepedCount = 0;
        }

        // Egenskap som säger som spelaren har vunnit spelet.
        public bool PlayerWon => false; // Stubbe

        // Egenskap som säger om spelaren har förlorat.
        public bool GameOver => false; // Stubbe


        // Försök röja en ruta. Returnerar false om ogiltigt drag. 
        public bool Sweeped(int row, int col) // Stubbe
        {
            return true;
        }

        // Försök flagga en ruta. Returnerar false om ogiltigt drag. 
        public bool Flag(int row, int col) // Stubbe
        {
            return true;
        }
    }
}
