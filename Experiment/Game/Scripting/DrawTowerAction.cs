using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawTower : Action
    {
        private VideoService videoService;
        
        public DrawTower(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Tower tower = (Tower)cast.GetFirstActor(Constants.TOWER_GROUP);
            Body body = tower.GetBody();

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