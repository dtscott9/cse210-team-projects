using System;
using System.Collections.Generic;

namespace Game.Guess
{
    public class Guess
    {
        public List<int> _guessProgress;
        public void CheckGuess(char userGuess, string hangManWord)
        {
            if (char.IsLetter(userGuess))
            {
                _guessProgress.Add(15);
            }
        }
    }
}