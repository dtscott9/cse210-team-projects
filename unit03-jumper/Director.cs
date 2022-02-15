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

        bool status;

        // This will take the player's guess, and determine if it belongs in the word.
        // If not, the loseLife() function will subtract a life from the player.
        public void trackGuess(char[] tempword, string guessWord)
        {
          terminal.CheckGuess(tempword, guessWord, status);
          if (status == false)
          {
            jumper.loseLife();
          }
        }
      
        // This is where all of the functions are brought together to make the game
        // correctly run. 
        public void gameStart()
        {
          word.genWord();
          string guessWord = word._wordToGuess;
          char[] tempword = new char[guessWord.Length];
          jumper.checkLife(keepPlaying);
          Console.WriteLine(guessWord);
          terminal.CreateDisplayWord(tempword, guessWord);
          while (keepPlaying != false)
          {
            trackGuess(tempword, guessWord);
            jumper.checkLife(keepPlaying);
            Console.WriteLine(tempword);
            
          }
        }
    }
}