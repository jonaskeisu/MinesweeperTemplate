using System;
using System.Collections.Generic;
using System.Text;

namespace MineSweeper
{
    // Typ för en ruta på spelplanen.
    struct Square
    {
        private int closeMineCount; // Antal minor på intilliggande rutor
        private bool flagged, boobyTrapped, sweeped;
        private char symbol;

        // Konstruktor som initiera en ny ruta på spelplanen.
        public Square(bool isBoobyTrapped)
        {
            closeMineCount = 0;
            flagged = false;
            this.boobyTrapped = isBoobyTrapped;
            sweeped = false;
            symbol = 'X';
        }

        // Egenskap som säger om rutan är flaggad för tillfället.
        public bool IsFlagged => false; // Stubbe

        // Egenskap som säger om rutan är minerad.
        public bool BoobyTrapped => false; // Stubbe

        // Egenskap som säger om rutan har blivit röjd. 
        public bool IsSweeped => false; // Stubbe

        // Egenskap som är symbolen som representerar rutan just nu om spelplanen skall ritas ut.
        public char Symbol => 'X'; // Stubbe
        
        // Egenskap som tilldelas true för alla rutor om spelaren röjer en minerad ruta 
        public bool GameOver 
        { 
            set { } // Stubbe
        }

        // Öka antalet minor på intilliggande rutor med 1 under initalisering av spelplan.
        public void IncrementCloseMineCount() // Stubbe
        {  
        }

        // Försök att flagga rutan. Returnerar false om ogiltigt drag
        public bool Flag() // Stubbe
        {
            return true;
        }

        // Försök röja rutan. Returnerar false om ogiltigt drag 
        public bool Sweep() // Stubbe
        {
            return true;
        }

        // Skriv ut spelplanen till konsolen.
        public void Print() // Stubbe
        {
        }
    }
}
