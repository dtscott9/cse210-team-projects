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
            if (char.IsLetter(userGuess))
            {
                _guessProgress.Add(15);
            }
        }
    }
}