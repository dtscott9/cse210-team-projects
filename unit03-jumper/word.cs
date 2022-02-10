using System;

namespace word 
{
    public class Word
    {
       private string[] randWord = {"python", "java", "javacript", "mysql", "function", "class", 
       "object", "variable", "loop", "visualstudio", "instance", "csharp", "statement", "script",
       "method", "code", "program", "software"};

        public Word()
        {
            
        }

        public string genWord()
        {
           Random rand = new Random();
           int index = rand.Next(randWord.Length);
           string wordIndex = randWord[index];
           
           return wordIndex;
        }
        
        
    }
}
