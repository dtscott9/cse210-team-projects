using System;

namespace unit04_greed.Game.Casting
{
    public class Artifact : Actor
    {
        
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
       public Artifact()
       {}
        public void makeGem(int COLS, int CELL_SIZE, int FONT_SIZE, string gem)
        {
            Random random = new Random();
            int x = random.Next(1, COLS);
            int y = 0;
            Point position = new Point(x, y);
            position = position.Scale(CELL_SIZE);

            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            Color color = new Color(r, g, b);

            Artifact artifact = new Artifact();
            SetText(gem);
            SetFontSize(FONT_SIZE);
            SetColor(color);
            SetPosition(position);

        }
        public void objectFalling()
        {   
            Random rand = new Random();
            int randNum = rand.Next(3, 8);
            Point velocity = new Point(0, randNum);
            SetVelocity(velocity);
        }
        
    }
}