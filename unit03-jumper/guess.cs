using System;
using System.Collections.Generic;
using terminal;

namespace Game.Guess
{
    public class Guess
    {
        public List<int> _guessProgress = new List<int>();
        
        
// cat character a
        public void CheckGuess(char[] tempword, char userGuess, string hangManWord)
        {//TODO ADD CHECK FOR LETTER later

            userGuess = char.Parse(Console.ReadLine());

            char[] letters = hangManWord.ToCharArray();

             for (int w = 0; w < hangManWord.Length; w++)
            {
                if (userGuess == hangManWord[w])
                {
                    tempword[w] = userGuess;
                }
                
            }
            
    
        }
        public void CheckWin()
        {
            Console.WriteLine(_guessProgress);
        }
    }
}