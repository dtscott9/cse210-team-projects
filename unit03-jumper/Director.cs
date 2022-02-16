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
        bool winner = false;

        // This will take the player's guess, and determine if it belongs in the word.
        // If not, the loseLife() function will subtract a life from the player.
        public void trackGuess(char[] tempword, string guessWord)
        {
            terminal.CheckGuess(tempword, guessWord);
            if (terminal.status == false)
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
                // add if statement here for print
                winner = IsPlaying(tempword);
                if (winner == false)
                {
                    Console.WriteLine(tempword);
                } else
                {
                  Console.WriteLine("Congradulations! You Won");
                  keepPlaying = false;
                }
            }
        }

        public bool IsPlaying(char[] tempword)
        {
            //converting char[] to string
            string str = new string(tempword);
            for (int i = 0; i < str.Length; i++)
            {
                if (tempword[i] == '_')
                {
                    return winner = false;
                }
            }
            return winner = true;
        }
    }
}