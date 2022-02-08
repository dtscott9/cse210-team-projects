using System;

namespace word 
{
    public class Word
    {
       private string[] randWord = {"python", "java", "javacript", "mysql", "function", "class", 
       "object", "variable", "loop", "visualstudio", "instance", "csharp", "statement"};

        public Word()
        {
            
        }

        public void genWord()
        {
           Random rand = new Random();
           int index = rand.Next(randWord.Length);
           Console.WriteLine($"{randWord[index]}");
        }
        
        
    }
}