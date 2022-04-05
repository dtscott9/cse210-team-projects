namespace Unit06.Game.Casting
{
    /// <summary>
    /// A thing that participates in the game.
    /// </summary>
    public class Stats : Actor
    {
        private int level;
        private int lives;
        private int goldCount;

        /// <summary>
        /// Constructs a new instance of Actor.
        /// </summary>
        public Stats(int level = 1, int lives = 3, int goldCount = 0, 
                bool debug = false) : base(debug)
        {
            this.level = level;
            this.lives = lives;
            this.goldCount = goldCount;
        }

        /// <summary>
        /// Adds one level.
        /// </summary>
        public void AddLevel()
        {
            level++;
        }

        /// <summary>
        /// Adds an extra life.
        /// </summary>
        public void AddLife()
        {
            lives++;
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="goldCount">The given points.</param>
        public void AddGold(int gold)
        {
            goldCount += gold;
        }

        public void SubtractGold (int gold)
        {
            goldCount -= gold;
        }

        /// <summary>
        /// Gets the level.
        /// </summary>
        /// <returns>The level.</returns>
        public int GetLevel()
        {
            return level;
        }

        /// <summary>
        /// Gets the lives.
        /// </summary>
        /// <returns>The lives.</returns>
        public int GetLives()
        {
            return lives;
        }

        /// <summary>
        /// Gets the score.
        /// </summary>
        /// <returns>The score.</returns>
        public int GetGoldCount()
        {
            return goldCount;
        }

        /// <summary>
        /// Removes a life.
        /// </summary>
        public void RemoveLife()
        {
            lives--;
            if (lives <= 0)
            {
                lives = 0;
            }
        }

        public void AddEnemyWave()
        {
            if (level <=9)
            {
            
            Constants.ENEMY_WAVE += 5;
            }
            else if (level >= 10 && level <= 19)
            {
                Constants.ENEMY_WAVE += 10;
            }
            else if (level >= 20 && level <= 29)
            {
                Constants.ENEMY_WAVE += 25;
            }
            else if (level >= 30 && level <= 39)
            {
                Constants.ENEMY_WAVE += 50;
            }
            else if (level >= 40 && level <= 49)
            {
                Constants.ENEMY_WAVE += 75;
            }
            else if (level >= 50 && level <= 99)
            {
                Constants.ENEMY_WAVE += 100;
            }
            else if (level >= 100)
            {
                Constants.ENEMY_WAVE += 500;
            }
        }
        
    }
}