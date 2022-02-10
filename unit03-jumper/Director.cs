using System;
using System.Collections.Generic;
using jumper;
using word;
using terminal;
using Game.Guess;

namespace director
{
    public class Director
    {
        Word word = new Word();

        Terminal terminal = new Terminal();

        Jumper jumper = new Jumper();
        
        bool playerGuess = true;
        bool keepPlaying = true;

        // Terminal t = new Terminal();
        // t.GetPlayerGuess();
        // Guess g = new Guess();
        // g.CheckGuess(t.GetPlayerGuess(), w._wordToGuess);
        // g.CheckWin();


        
        
        public void CreateWord()
        {
          word.genWord();
          string guessWord = word._wordToGuess;
  

          terminal.CreateDisplayWord(guessWord);
        }

        public void gameStart()
        {
          CreateWord();
          while (keepPlaying == true)
          {
            
          }
        }


        

    
            // Word w = new Word();
            // w.genWord();



            
        
        
        
        

        
    }
}