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
        
        Guess guess = new Guess();
        
        bool playerGuess = true;
        bool keepPlaying = true;

        // Terminal t = new Terminal();
        // t.GetPlayerGuess();
        // Guess g = new Guess();
        // g.CheckGuess(t.GetPlayerGuess(), w._wordToGuess);
        // g.CheckWin();


        public void trackGuess(char[] tempword, char userGuess, string guessWord)
        {
          
          guess.CheckGuess(tempword, userGuess, guessWord);
          guess.check(userGuess, guessWord);
          
        }
        
        public void CreateWord()
        {
          word.genWord();
        }

        public void dashWord(char[] tempword, string guessWord)
        { 
          terminal.CreateDisplayWord(tempword, guessWord);
        }

        public void displayMan()
        {
          jumper.checkLife();
        }

        public void gameStart()
        {
          char guess = terminal._playerGuess;
          CreateWord();
          string guessWord = word._wordToGuess;
          char[] tempword = new char[guessWord.Length];
          
          displayMan();
          Console.WriteLine(guessWord);
          dashWord(tempword, guessWord);
          while (keepPlaying == true)
          {
            
            trackGuess(tempword, guess, guessWord);
            displayMan();
            Console.WriteLine(tempword);
          }
        }


        

    



            
        
        
        
        

        
    }
}