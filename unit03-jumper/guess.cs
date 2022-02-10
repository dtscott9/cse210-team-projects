using System;
using System.Collections.Generic;

namespace Game.Guess
{
    public class Guess
    {
        public List<int> _guessProgress = new List<int>();
        
        
// cat character a
        public void CheckGuess(char userGuess, string hangManWord)
        {
            if (char.IsLetter(userGuess) & hangManWord.Contains(userGuess))
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