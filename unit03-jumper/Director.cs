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

        public void main()
        {
        }
        Word word = new Word();
        Guess guess = new Guess();

        Terminal terminal = new Terminal();

        Jumper jumper = new Jumper();
        
        bool playerGuess = true;
        bool keepPlaying = true;


        public void GetInputs()
        {
            //get word we are guessing
            //get guess from player
            string guessWord = CreateWord();
            terminal.SetPlayerGuess();
            guess.CheckGuess(terminal.GetPlayerGuess(), guessWord);
            guess.CheckWin();
            
            terminal.CreateDisplayWord(guessWord);
        }   

        public void doCalculations()
        {
        // Terminal t = new Terminal();
        // t.GetPlayerGuess();
        // Guess g = new Guess();
        // g.CheckGuess(t.GetPlayerGuess(), w._wordToGuess);
        // g.CheckWin();
        }     
  
        public void gameStart()
        {
          CreateWord();
          while (keepPlaying == true)
          {
            
          }
        }

        public string CreateWord()
        {
          string temp = word.genWord();
          return temp;
        }

        public void DisplayWord()
        {
            terminal.CreateDisplayWord(word._wordToGuess);
        }
    
            // Word w = new Word();
            // w.genWord();        
    }
}