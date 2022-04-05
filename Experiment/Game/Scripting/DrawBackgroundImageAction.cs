using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawBackgroundImage : Action
    {
        private VideoService videoService;


        public DrawBackgroundImage(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            BackgroundDrawn(cast, Constants.BACKGROUND_IMAGE_GROUP);
      
        }

        public void BackgroundDrawn(Cast cast, string constants)
        {
                foreach (BackgroundImg background in cast.GetActors(constants))
            {
                Body body = background.GetBody();
                if (background.IsDebug())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    videoService.DrawRectangle(size, pos, Constants.BLUE, false);
                }


                Image image = background.GetImage();
                Point position = body.GetPosition();
                videoService.DrawImage(image, position);
            }
        }
    }
}