using System;
using System.Collections.Generic;

namespace jumper 
{

    public class Jumper 
    {
        
        
        public Jumper()
        {
            
        }

        public void jumpMan(List<string> man) 
        {
        
          
           man.Add(@"
                     ---
                    /   \
                     ---
                    \   /
                     \ /
                      0
                     /|\
                     / \");
            man.Add(@"
                     
                    /   \
                     ---
                    \   /
                     \ /
                      0
                     /|\
                     / \");
            man.Add(@"
                     
                     ---
                    \   /
                     \ /
                      0
                     /|\
                     / \");
            man.Add(@"
                     
                    \   /
                     \ /
                      0
                     /|\
                     / \");
            man.Add(@"
                    
                     \ /
                      0
                     /|\
                     / \");
            man.Add(@"
                    
                      x
                     /|\
                     / \"); 
        }
        // public void display()
        // {
        //     Console.WriteLine($"{man[1]}");
        // }
    }
}

