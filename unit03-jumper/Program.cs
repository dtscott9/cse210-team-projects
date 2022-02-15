using System;
using word;
using jumper;
using director;
using Game.Guess;
using System.Collections.Generic;

namespace unit03_jumper
{
    class Program
    {
        // The class method gameStart is called from director, and the game is started.
        static void Main(string[] args)
        {
            Director dir = new Director();
            dir.gameStart();
        }
    }
}
