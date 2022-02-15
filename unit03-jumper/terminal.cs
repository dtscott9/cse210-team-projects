using System;

namespace terminal
{
    public class Terminal
    {
        private string displayWord;
        public char _playerGuess;

        public char SetPlayerGuess()
        {
            Console.WriteLine("Guess a chararacter");
            _playerGuess = char.Parse(Console.ReadLine());

            return _playerGuess;
        
        }

        public char GetPlayerGuess()
        {
            return _playerGuess;
        }
        //TODO input guess
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