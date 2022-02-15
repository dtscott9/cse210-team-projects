using System;
using System.Collections.Generic;

namespace jumper 
{

    public class Jumper 
    {
        private int playerLives = 5;

        private List<string> man = new List<string>();        
        
        public Jumper()
        {
            
        }

        public void loseLife(string guess)
        {
            playerLives -= 1;
        }

        public void jumpMan() 
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
        public void checkLife() 
        {
            jumpMan();
            if (playerLives == 5)
            {
                Console.WriteLine($"{man[0]}");
            }
            
            if (playerLives == 4)
            {
                Console.WriteLine($"{man[1]}");
            }
            else if (playerLives == 3) 
            {
                Console.WriteLine($"{man[2]}");
            }
            else if (playerLives == 2) 
            {
                Console.WriteLine($"{man[3]}");
            }
            else if (playerLives == 1) 
            {
                Console.WriteLine($"{man[4]}");
            }
            else if (playerLives == 0) 
            {
                Console.WriteLine($"{man[5]}");
            }
        }
    }
}

