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

        public void loseLife()
        {
            playerLives -= 1;
        }
        // Adds each of the different possible diplays to the man list.
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
                     / \
                  Game Over"); 
        }
        
        // This will determine which display needs to be in the terminal. The display depends on how
        // many lives or guesses the player has left.
        public void checkLife(bool keepPlaying) 
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
                keepPlaying = false;
            }
        }
    }
}

