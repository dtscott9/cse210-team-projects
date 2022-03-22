using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawTurret : Action
    {
        private VideoService videoService;
        
        public DrawTurret(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Turret ball = (Turret)cast.GetFirstActor(Constants.TURRET_GROUP);
            Body body = ball.GetBody();

            Rectangle rectangle = body.GetRectangle();
            Point size = rectangle.GetSize();
            Point pos = rectangle.GetPosition();
            videoService.DrawRectangle(size, pos, Constants.BLUE, false);
        

            // Image image = ball.GetImage();
            // Point position = body.GetPosition();
            // videoService.DrawImage(image, position);
        }
    }
}