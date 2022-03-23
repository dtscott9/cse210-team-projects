using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{

    public class Enemy : Actor
    {
        private int _health = 20;
        private int _damageDealt = 10;

        private Body body;
        private Image image;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Enemy(Body body, Image image, bool debug = false) : base(debug)
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

        // public void SetHealth(int health)
        // {
        //     _health = health;
        // }
        public int GetHealth()
        {
            return _health;
        }

        // public void SetDamageDealt(int damageDealt)
        // {
        //     _damageDealt = damageDealt;
        // }

        public int GetDamageDealt()
        {
            return _damageDealt;
        }


    }
}