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
        static void Main(string[] args)
        {
            Director dir = new Director();
            dir.GetInputs();
            dir.CreateWord();
        }
    }
}
