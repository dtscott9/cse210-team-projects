using System;
using System.Collections.Generic;
using terminal;
using jumper;

namespace Game.Guess
{
    public class Guess
    {
        public List<int> _guessProgress = new List<int>();

        Jumper jum = new Jumper();
        
        
// cat character a
        public void CheckGuess(char[] tempword, char userGuess, string hangManWord)
        {//TODO ADD CHECK FOR LETTER later

            Console.WriteLine("Guess a chararacter");
            userGuess = char.Parse(Console.ReadLine());

             for (int w = 0; w < hangManWord.Length; w++)
            {
                if (userGuess == hangManWord[w])
                {
                    tempword[w] = userGuess;
                } 

            } 
        
        }
        public void check(char userGuess, string hangManWord)
        {
           
            
        }
        public void CheckWin()
        {
            Console.WriteLine(_guessProgress);
        }
    }
}