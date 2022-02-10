using System;
using System.Collections.Generic;
using jumper;
using word;
using Game.Guess;

namespace director
{
    public class Director
    {
        public void main()
        {
            List<string> man = new List<string>();

            Jumper jumper = new Jumper();
            jumper.jumpMan(man);

            Console.WriteLine($"{man[0]}");

            Word w = new Word();
            w.genWord();
            string userWord = w._wordToGuess;

            Guess g = new Guess();
            g.CheckGuess(w._wordToGuess);
            g.CheckWin();

        }
    }
}