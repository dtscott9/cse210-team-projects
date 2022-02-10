using System;
using System.Collections.Generic;

namespace Game.Guess
{
    public class Guess
    {
        public List<int> _guessProgress = new List<int>();
        
        
// cat character a
        public void CheckGuess(char userGuess, string hangManWord)
        {//TODO ADD CHECK FOR LETTER later
            if (hangManWord.Contains(userGuess))
            {
                _guessProgress.Add(hangManWord[userGuess]);
            }
        }

        public void CheckWin()
        {
            Console.WriteLine(_guessProgress);
        }
    }
}