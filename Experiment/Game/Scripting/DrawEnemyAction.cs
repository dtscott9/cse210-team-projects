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
                Text healthBarText = enemy.GetHealthBarText();
                if (enemy.IsDebug())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    videoService.DrawRectangle(size, pos, Constants.WHITE, false);
                    videoService.DrawText(healthBarText, pos);
                }
                
                
                Animation animation = enemy.GetAnimation();
                Image image = animation.NextImage();
                Point position = body.GetPosition();
                videoService.DrawImage(image, position);
                videoService.DrawText(healthBarText, position);

            }
        }

    }
}