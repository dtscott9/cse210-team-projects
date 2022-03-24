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
            foreach (Enemy enemy in cast.GetActors(Constants.ENEMY_GROUP))
            {
                Body body = enemy.GetBody();

                Rectangle rectangle = body.GetRectangle();
                Point size = rectangle.GetSize();
                Point pos = rectangle.GetPosition();
                videoService.DrawRectangle(size, pos, Constants.WHITE, false);

                Text healthBarText = enemy.GetHealthBarText();

                videoService.DrawText(healthBarText, pos);
            }

            // Image image = wall.GetImage();
            // Point position = body.GetPosition();
            // videoService.DrawImage(image, position);
        }

    }
}