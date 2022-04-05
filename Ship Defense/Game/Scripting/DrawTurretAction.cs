using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawTurret : Action
    {
        private VideoService videoService;

        private string turrets = Constants.TURRET_GROUP;
        private string lazer_turrets = Constants.LAZER_GROUP;
        private string plasma_turrets = Constants.PLASMA_GROUP;

        public DrawTurret(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            TurretDrawn(cast, turrets);
            TurretDrawn(cast, lazer_turrets);
            TurretDrawn(cast, plasma_turrets);
        }

        public void TurretDrawn(Cast cast, string constants)
        {
                foreach (Turret turret in cast.GetActors(constants))
            {
                Body body = turret.GetBody();
                if (turret.IsDebug())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    videoService.DrawRectangle(size, pos, Constants.BLUE, false);
                }


                Image image = turret.GetImage();
                Point position = body.GetPosition();
                videoService.DrawImage(image, position);
            }
        }
    }
}