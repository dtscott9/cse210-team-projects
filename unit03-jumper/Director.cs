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

        public void GetInputs()
        {
            //get word we are guessing
            //get guess from player
            terminal.SetPlayerGuess();
            guess.CheckGuess(terminal.GetPlayerGuess(), word._wordToGuess);
            guess.CheckWin();
            word.genWord();
            string guessWord = word._wordToGuess;

            terminal.CreateDisplayWord(guessWord);
        }   


        public string CreateWord()
        {
          string temp = word.genWord();
          terminal.CreateDisplayWord(word._wordToGuess);
          return temp;
        }
    
            // Word w = new Word();
            // w.genWord();



            
        
        
        
        

        
    }
}