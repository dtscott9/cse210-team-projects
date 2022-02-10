using System;
using System.Collections.Generic;
using jumper;
using word;
using Game.Guess;
using terminal;

namespace director
{
    public class Director
    {
        public void main()
        {
            List<string> man = new List<string>();

            Jumper jumper = new Jumper();
            jumper.jumpMan(man);

            Word w = new Word();
            w.genWord();

            Terminal t = new Terminal();
            t.GetPlayerGuess();

            Guess g = new Guess();
            g.CheckGuess(t.GetPlayerGuess(), w._wordToGuess);
            g.CheckWin();

        }
    }
}