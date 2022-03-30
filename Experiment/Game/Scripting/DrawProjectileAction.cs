using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawProjectile : Action
    {
        private VideoService videoService;

        public DrawProjectile(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            foreach (Projectile projectile in cast.GetActors(Constants.PROJECTILE_GROUP))
            {
                // Projectile projectile = (Projectile)cast.GetFirstActor(Constants.PROJECTILE_GROUP);
                Body body = projectile.GetBody();
                if (projectile.IsDebug())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    videoService.DrawRectangle(size, pos, Constants.GREEN, false);
                }

                // Image image = projectile.GetImage();
                Point position = body.GetPosition();
                Animation animation = projectile.GetAnimation();
                Image image = animation.NextImage();
                videoService.DrawImage(image, position);
            }
        }
    }
}