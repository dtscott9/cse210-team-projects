using System;
using word;
using Game.Guess;

namespace unit03_jumper
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Word w = new Word();
            w.genWord();

            Guess g = new Guess();
            g.CheckGuess('c', "Catco");
        }
    }
}
