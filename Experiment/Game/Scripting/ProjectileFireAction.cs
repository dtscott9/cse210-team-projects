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

        public async void Execute(Cast cast, Script script, ActionCallback callback)
        {
            foreach(Turret turret in cast.GetActors(Constants.TURRET_GROUP))
            {
                Body Tbody = turret.GetBody();
                if(turret.ShouldFire())
                {
                    Console.WriteLine("success");
                
                    Point position = Tbody.GetPosition();
                    Point size = new Point(Constants.PROJECTILE_WIDTH, Constants.PROJECTILE_HEIGHT);
                    Point velocity = new Point(0, 10);

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