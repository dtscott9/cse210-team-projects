using System;
using System.Collections.Generic;

namespace Game.Guess
{
    public class Guess
    {
        public List<int> _guessProgress = new List<int>();
        
        
// cat character a
        public void CheckGuess(string userGuess, string hangManWord)
        {//TODO ADD CHECK FOR LETTER later
            if (hangManWord.Contains(userGuess))
            {
                _guessProgress.Add(hangManWord.IndexOf(userGuess));
                Console.WriteLine(hangManWord.IndexOf(userGuess));
            }
        }

        public void CheckWin()
        {
            Console.WriteLine(_guessProgress);
        }
    }
}