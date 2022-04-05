using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{
    
    public class Wall : Actor
    {

        private Body body;
        private Animation animation;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Wall(Body body, Animation animation, bool debug = false) : base(debug)
        {
            this.body = body;
            this.animation = animation;
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


        public Animation GetAnimation()
        {
            return animation;
        }
    }
}