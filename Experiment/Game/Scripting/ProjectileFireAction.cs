using System;
using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    public class ProjectileFireAction : Action
    {

        public ProjectileFireAction(AudioService audioService)
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            foreach(Turret turret in cast.GetActors(Constants.TURRET_GROUP))
            {
                if(turret.ShouldFire())
                {
                    Console.WriteLine("success");
                    int x = 50;
                    int y = 50;

                    Point position = new Point(x, y);
                    Point size = new Point(Constants.TOWER_WIDTH, Constants.TOWER_HEIGHT);
                    Point velocity = new Point(10, 0);

                    Body body = new Body(position, size, velocity);
                    Image image = new Image(Constants.PROJECTILE_IMAGE);
                    Projectile projectile = new Projectile(body, image, false);
                    cast.AddActor(Constants.PROJECTILE_GROUP, projectile);
                    turret.ResetCountdown();
                }
                turret.CountDown();
            }
            
        }   

    }

}