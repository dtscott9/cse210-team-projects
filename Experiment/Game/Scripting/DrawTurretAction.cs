using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawTurretAction : Action
    {
        private VideoService videoService;
        
        public DrawTurretAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Turret ball = (Turret)cast.GetFirstActor(Constants.BALL_GROUP);
            Body body = ball.GetBody();

            Rectangle rectangle = body.GetRectangle();
            Point size = rectangle.GetSize();
            Point pos = rectangle.GetPosition();
            videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
        

            // Image image = ball.GetImage();
            // Point position = body.GetPosition();
            // videoService.DrawImage(image, position);
        }
    }
}