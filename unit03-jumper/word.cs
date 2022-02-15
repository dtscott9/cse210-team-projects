using System;

namespace word 
{
    public class Word
    {
        public string _wordToGuess;

        // This is an array that contains all possible words that the player may have to guess.
       private string[] randWord = {"python", "java", "javacript", "mysql", "function", "class", 
       "object", "variable", "loop", "visualstudio", "instance", "csharp", "statement", "script",
       "method", "code", "program", "software"};
        public Word()
        {
            
        }
        
        // This method randomly chooses a word from the randWord array.
        public string genWord()
        {
           Random rand = new Random();
           int index = rand.Next(randWord.Length);
           _wordToGuess = randWord[index];
           return _wordToGuess;
        }   
    }
}
