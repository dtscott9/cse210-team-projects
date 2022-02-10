using System;

namespace terminal
{
    public class Terminal
    {
        private string displayWord;
        private string _playerGuess;

        public void SetPlayerGuess()
        {
            Console.WriteLine("Guess a chararacter");
            _playerGuess = Console.ReadLine();
            // if (playerGuess.Length == 1)
            // {
            //     _playerGuess = playerGuess;
            // } else
            // {
            //     Console.WriteLine("Sorry, your guess is too long");
            // }
        }

        public string GetPlayerGuess()
        {
            return _playerGuess;
        }
        //TODO input guess
        public string CreateDisplayWord(string guessWord) //gues word is the word the user trys to guess
        {
            string tempWord = "";
            for (int i = 0; i < guessWord.Length; i++)
            {
                tempWord = tempWord + "_";
            }

            Console.WriteLine(tempWord);
            return tempWord;
        }

    }
}