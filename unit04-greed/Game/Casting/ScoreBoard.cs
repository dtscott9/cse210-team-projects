namespace unit04_greed.Game.Casting
{
    public class ScoreBoard : Actor
    {
        private int score;
        public ScoreBoard()
        {

        }

        public int GetScore()
        {
            return score;
        }
        
        public void AddScore()
        {
            score += 100;
        }

        public void SubtrScore()
        {
            score -= 100;
        }
    }
}