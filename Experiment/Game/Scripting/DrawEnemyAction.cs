using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawWEnemy : Action
    {
        private VideoService videoService;
        
        public DrawWEnemy(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            foreach(Enemy enemy in cast.GetActors(Constants.ENEMY_GROUP))
            {
            Body body = enemy.GetBody();

            Rectangle rectangle = body.GetRectangle();
            Point size = rectangle.GetSize();
            Point pos = rectangle.GetPosition();
            videoService.DrawRectangle(size, pos, Constants.WHITE, false);
            DrawEnemyLabel(cast, Constants.ENEMY_HEALTH_GROUP, Constants.ENEMY_HEALTH_FORMAT, Constants.ENEMY_HEALTH);
            }

            // Image image = wall.GetImage();
            // Point position = body.GetPosition();
            // videoService.DrawImage(image, position);
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