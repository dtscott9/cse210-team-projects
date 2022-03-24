using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawEnemyHealthBar : Action
    {
        private VideoService videoService;
        
        public DrawEnemyHealthBar(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
            Enemy enemy = (Enemy)cast.GetFirstActor(Constants.ENEMY_GROUP);
            DrawEnemyLabel(cast, Constants.ENEMY_HEALTH_GROUP, Constants.ENEMY_HEALTH_FORMAT, Constants.ENEMY_HEALTH);
        }
        private void DrawEnemyLabel(Cast cast, string group, string format, int data)
        {
            foreach(Label label in cast.GetActors(Constants.ENEMY_HEALTH_GROUP))
            {
            Text text = label.GetText();
            text.SetValue(string.Format(format, data));
            Point position = label.GetPosition();
            videoService.DrawText(text, position);
            }
        }
    }
}