using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawButton : Action
    {
        private VideoService videoService;

        public DrawButton(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            foreach (Button button in cast.GetActors(Constants.BUTTON_GROUP))
            {
                Body body = button.GetBody();
                if (button.IsDebug())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    videoService.DrawRectangle(size, pos, Constants.GREEN, false);
                }

                Image image = button.GetImage();
                Point position = body.GetPosition();
                videoService.DrawImage(image, position);
            }
        }
    }
}