using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{

    public class Enemy : Actor
    {
        private int _damageDealt = 10;
        private int _xCoordinate;
        private int _yCoordinate;
        private int _goldDropped;

        private int _health = 30;
        private Body body;
        private Animation animation;
        private Text _healthBarText; 
        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Enemy(Body body, Animation animation, int _goldDropped, bool debug = false) : base(debug)
        {
            this.body = body;
            this.animation = animation;
            _healthBarText = new Text($"{_health}/30", Constants.FONT_FILE, Constants.ENEMY_FONT_SIZE, Constants.ALIGN_CENTER, Constants.WHITE);
            this._goldDropped = _goldDropped;
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

        internal Text GetHealthBarText()
        {       
            _healthBarText.SetValue($"{_health}/30");
            return _healthBarText;
        }

        public void TakeDamage(int ammount)
        {
            _health -= ammount;
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns>The image.</returns>
        public Animation GetAnimation()
        {
            return animation;
        }

        // public void SetDamageDealt(int damageDealt)
        // {
        //     _damageDealt = damageDealt;
        // }

        public int GetDamageDealt()
        {
            return _damageDealt;
        }

        public int GetHealth()
        {
            return _health;
        }

        public int GetGoldDropped()
        {
            return _goldDropped;
        }


    }
}