using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{
    /// <summary>
    /// 
    /// </summary>
    public class Turret : Actor
    {
        private static Random random = new Random();

        private Body body;
        private Image image;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Turret(Body body, Image image, bool debug = false) : base(debug)
        {
            this.body = body;
            this.image = image;
        }

        /// <summary>
        /// Bounces the ball horizontally.
        /// </summary>
        public void BounceX()
        {
            Point velocity = body.GetVelocity();
            double rn = (random.NextDouble() * (1.2 - 0.8) + 0.8);
            double vx = velocity.GetX() * -1;
            double vy = velocity.GetY();
            Point newVelocity = new Point((int)vx, (int)vy);
            body.SetVelocity(newVelocity);
        }

        /// <summary>
        /// Bounces the ball vertically.
        /// </summary>
        public void BounceY()
        {
            Point velocity = body.GetVelocity();
            double rn = (random.NextDouble() * (1.2 - 0.8) + 0.8);
            double vx = velocity.GetX();
            double vy = velocity.GetY() * -1;
            Point newVelocity = new Point((int)vx, (int)vy);
            body.SetVelocity(newVelocity);
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

      
    }
}