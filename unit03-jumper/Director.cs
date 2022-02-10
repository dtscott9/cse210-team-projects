using System;
using System.Collections.Generic;
using word;
using terminal;
using jumper;

namespace director
{
    public class Director
    {
        
        
       
        Word word = new Word();

        Terminal terminal = new Terminal();

        Jumper jumper = new Jumper();
        
        bool playerGuess = true;

        public void CreateWord()
        {
          string guessWord = word.genWord();
        }
        



            
        
        
        
        

        
    }
}