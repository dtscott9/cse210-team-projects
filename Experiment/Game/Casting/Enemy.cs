using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{

    public class Enemy : Actor
    {
        private int _health = 20;
        private int _damageDealt = 10;
        private int _xCoordinate;
        private int _yCoordinate;


        private Body body;
        private Image image;
        private Label _healthBar;

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

        public int GetXCoordinate()
        {
            return _xCoordinate;
        }
        public int GetYCoordinate()
        {
            return _yCoordinate;
        }
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

        public Label GetLabel()
        {
            return _healthBar;
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