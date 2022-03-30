using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawWall : Action
    {
        private VideoService videoService;

        public DrawWall(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            foreach (Wall wall in cast.GetActors(Constants.WALL_GROUP))
            {
                Body body = wall.GetBody();
                if (wall.IsDebug())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    videoService.DrawRectangle(size, pos, Constants.GREEN, false);
                }

                Image image = wall.GetImage();
                Point position = body.GetPosition();
                videoService.DrawImage(image, position);
            }
        }
    }
}