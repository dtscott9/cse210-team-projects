using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawProjectile : Action
    {
        private VideoService videoService;
        private string turrets = Constants.PROJECTILE_GROUP;
        private string lazer_turrets = Constants.PROJECTILE_GROUP_2;
        private string plasma_turrets = Constants.PROJECTILE_GROUP_3;

        public DrawProjectile(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            ProjectileDrawn(cast, turrets);
            ProjectileDrawn(cast, lazer_turrets);
            ProjectileDrawn(cast, plasma_turrets);
        }
        public void ProjectileDrawn(Cast cast, string constants)
        {
                foreach (Projectile projectile in cast.GetActors(constants))
            {
                Body body = projectile.GetBody();
                if (projectile.IsDebug())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    videoService.DrawRectangle(size, pos, Constants.GREEN, false);
                }

            
                Point position = body.GetPosition();
                Animation animation = projectile.GetAnimation();
                Image image = animation.NextImage();
                videoService.DrawImage(image, position);
            }
        }
    }
}