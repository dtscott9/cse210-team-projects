using System;
using System.Collections.Generic;
using jumper;
using word;
using terminal;
using Game.Guess;
using terminal;

namespace director
{
    public class Director
    {
        Word word = new Word();

        Terminal terminal = new Terminal();

        Jumper jumper = new Jumper();
        
        bool playerGuess = true;

        public void CreateWord()
        {
          string guessWord = word.genWord();

          terminal.CreateDisplayWord(guessWord);
        }
        

    
            // Word w = new Word();
            // w.genWord();

            // Terminal t = new Terminal();
            // t.GetPlayerGuess();

            // Guess g = new Guess();
            // g.CheckGuess(t.GetPlayerGuess(), w._wordToGuess);
            // g.CheckWin();


            
        
        
        
        

        
    }
}