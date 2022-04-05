using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{

    public class Turret : Actor
    {

        private static Random random = new Random();
        private int _bulletCountDown = Constants.TURRET_COUNTDOWN;
        private int _lazerCountDown = Constants.LAZER_COUNTDOWN;
        private int _plasmaCountDown = Constants.PLASMA_COUNTDOWN;

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


        public void CountDown()
        {
            _bulletCountDown -= 1;
            _lazerCountDown -= 1;
            _plasmaCountDown -= 1;
        }

        public bool ShouldFireBullet()
        {
            bool ShouldFire;

            if (_bulletCountDown <= 0)
            {
                ShouldFire = true;
            }
            else
            {
                ShouldFire = false;
            }
            return ShouldFire;
        }
        public bool ShouldFireLazer()
        {
            bool ShouldFire;

            if (_lazerCountDown <= 0)
            {
                ShouldFire = true;
            }
            else
            {
                ShouldFire = false;
            }
            return ShouldFire;
        }

        public bool ShouldFirePlasma()
        {
            bool ShouldFire;

            if (_plasmaCountDown <= 0)
            {
                ShouldFire = true;
            }
            else
            {
                ShouldFire = false;
            }
            return ShouldFire;
        }
        public void ResetBulletCountdown()
        {
            _bulletCountDown = Constants.TURRET_COUNTDOWN;
        }
        public void ResetLazerCountdown()
        {
            _lazerCountDown = Constants.LAZER_COUNTDOWN;
        }
        public void ResetPlasmaCountdown()
        {
            _plasmaCountDown = Constants.PLASMA_COUNTDOWN;
        }

    }
}