using System;
using System.Collections.Generic;

namespace unit05_cycle.Game.Casting
{
    public class Score : Actor
    {
       private int points = 0;

        /// <summary>
        /// Constructs a new instance of an Food.
        /// </summary>
        public Score()
        {
            AddPoints(0);
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddPoints(int points)
        {
            this.points += points;
            SetText($"Score: {this.points}");
        }
    }
}