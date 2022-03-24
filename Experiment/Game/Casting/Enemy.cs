using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{

    public class Enemy : Actor
    {
        private int _damageDealt = 10;
        private int _xCoordinate;
        private int _yCoordinate;

        private int _health = 18;
        private Body body;
        private Image image;
        private Text _healthBarText; 
        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Enemy(Body body, Image image, bool debug = false) : base(debug)
        {
            this.body = body;
            this.image = image;
            _healthBarText = new Text($"{_health}/20", Constants.FONT_FILE, Constants.ENEMY_FONT_SIZE, Constants.ALIGN_CENTER, Constants.WHITE);

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
            _healthBarText.SetValue($"{_health}/20");
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