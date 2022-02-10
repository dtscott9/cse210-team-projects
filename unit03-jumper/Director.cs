using System;
using System.Collections.Generic;
using jumper;

namespace director
{
    public class Director
    {
        public void main()
        {
            List<string> man = new List<string>();
            
            Jumper jumper = new Jumper();
            jumper.jumpMan(man);

            Console.WriteLine($"{man[0]}");
        

            
        }
        
        
        

        
    }
}