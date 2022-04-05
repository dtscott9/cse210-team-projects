using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{
    
    public class Tower : Actor
    {
        private int health = 100;
        private static Random random = new Random();

        private Body body;
        private Image image;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Tower(Body body, Image image, bool debug = false) : base(debug)
        {
            this.body = body;
            this.image = image;
        }

        /// <summary>
        /// Gets the body.
        /// </summary>
        /// <returns>The body.</returns>
        public Body GetBody()
        {
            return body;
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns>The image.</returns>
        public Image GetImage()
        {
            return image;
        }

        public int GetHealth()
        {
            return health;
        }

        public void TakeDamage(int dmg)
        {
            health -= dmg;
        }

    }
}