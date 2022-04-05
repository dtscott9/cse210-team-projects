using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{

    public class Projectile : Actor
    {
        private int _damageDealt = 10;
        private int _xCoordinate;
        private int _yCoordinate;
        private Animation animation;

        private Body body;
        private Image image;
        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Projectile(Body body, Animation animation, Image image, bool debug = false) : base(debug)
        {
            this.body = body;
            this.image = image;
            this.animation = animation;
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
        public Animation GetAnimation()
        {
            return animation;
        }
        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns>The image.</returns>
        public Image GetImage()
        {
            return image;
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