using System;

namespace Game.Guess
{
    public class Guess
    {
        public List<int> _guessProgress;
// cat character a
        public void CheckGuess(char userGuess, string hangManWord)
        {
            if (char.IsLetter(userGuess))
            {
                _guessProgress.Add(hangManWord.IndexOf(userGuess));
            }
        }
    }
}