using System;

namespace terminal
{
    public class Terminal
    {
        public char _playerGuess;
        // Checks to see if the player's guess is contained in the word. If so, it adds that 
        // letter to the char[] which contains all the letters of the word. If not, status will
        // be false which will lead to the player losing a life. 
        public void CheckGuess(char[] tempword, string hangManWord, bool status)
        {
            Console.WriteLine("Guess a chararacter");
            _playerGuess = char.Parse(Console.ReadLine());

             for (int w = 0; w < hangManWord.Length; w++)
            {
                if (_playerGuess == hangManWord[w])
                {
                    tempword[w] = _playerGuess;
                } 
                else if (_playerGuess != hangManWord[w])
                {
                    status = false;
                }
            
            } 
        
        }
        // This takes all of the letters of the word the player needs to guess and converts them
        // to dashes. 
        public char[] CreateDisplayWord(char[] tempword,string guessWord) //gues word is the word the user trys to guess
        {
            
            for (int i = 0; i < guessWord.Length; i++)
            {
                tempword[i] = '_';
            }

            Console.WriteLine(tempword);
            return tempword;
        }

    }
}