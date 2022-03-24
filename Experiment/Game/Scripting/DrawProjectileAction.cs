using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawProjectileAction : Action
    {
        private VideoService videoService;
        
        public DrawProjectileAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Projectile projectile = (Projectile)cast.GetFirstActor(Constants.PROJECTILE_GROUP);
            Body body = projectile.GetBody();

            Rectangle rectangle = body.GetRectangle();
            Point size = rectangle.GetSize();
            Point pos = rectangle.GetPosition();
            videoService.DrawRectangle(size, pos, Constants.GREEN, false);


            // Image image = ball.GetImage();
            // Point position = body.GetPosition();
            // videoService.DrawImage(image, position);
        }
    }
}