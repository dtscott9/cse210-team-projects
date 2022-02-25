namespace unit04_greed.Game.Casting
{
    public class ScoreBoard : Actor
    {
        public ScoreBoard()
        {

        }
        
        public void AddScore(int score)
        {
            score += 100;
        }

        public void SubtrScore(int score)
        {
            score -= 100;
        }
    }
}