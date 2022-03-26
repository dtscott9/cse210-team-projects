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
            foreach (Turret turret in cast.GetActors(Constants.TURRET_GROUP))
            {
                Body Tbody = turret.GetBody();
                Point tPosition = Tbody.GetPosition();
                int velx = tPosition.GetX();
                int vely = tPosition.GetY();
                if (cast.GetActors(Constants.ENEMY_GROUP).Count > 0)
                {
                    if (turret.ShouldFire())
                    {

                        Enemy enemy = (Enemy)cast.GetFirstActor(Constants.ENEMY_GROUP);
                        Body eBody = enemy.GetBody();
                        Point ePosition = eBody.GetPosition();


                        Console.WriteLine("success");

                        Point position = Tbody.GetPosition();
                        Point size = new Point(Constants.PROJECTILE_WIDTH, Constants.PROJECTILE_HEIGHT);
                        int velocityX = ePosition.GetX() / 20;
                        int velocityY = ePosition.GetY() / 20;
                        Point velocity = new Point(velocityX, velocityY);


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

}