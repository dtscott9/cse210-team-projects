using System;
using System.Linq;
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
                if (cast.GetActors(Constants.ENEMY_GROUP).Count > 0)
                {
                    Body Tbody = turret.GetBody();
                    Point tPosition = Tbody.GetPosition();
                    int tX = tPosition.GetX();
                    int tY = tPosition.GetY();
                    int velx = tPosition.GetX() / Constants.TURRET_VELOCITY;
                    int vely = tPosition.GetY() / Constants.TURRET_VELOCITY;
                    foreach (Enemy enemy in cast.GetActors(Constants.ENEMY_GROUP))
                    {
                        Body eBody = enemy.GetBody();
                        Point ePosition = eBody.GetPosition();
                        int eX = ePosition.GetX();

                        if (eX <= tX && eX >= tX - 300 || eX >= tX && eX <= tX + 300)
                        {
                            if (turret.ShouldFire())
                            {



                                Console.WriteLine("success");
                                if (tY <= 340)
                                {
                                    tY += 30;
                                }

                                else
                                {
                                    tY -= 15;
                                }
                                Point position = new Point(tX, tY);
                                Point size = new Point(Constants.PROJECTILE_WIDTH, Constants.PROJECTILE_HEIGHT);
                                int velocityX = ePosition.GetX() / Constants.TURRET_VELOCITY;
                                int velocityY = ePosition.GetY() / Constants.TURRET_VELOCITY;
                                Point velocity = new Point((velocityX - velx) + 2, velocityY - vely);

                                Body body = new Body(position, size, velocity);
                                Image image = new Image(Constants.PROJECTILE_IMAGE);
                                Animation animation = new Animation(Constants.PROJECTILE_IMAGES_1, Constants.PROJECTILE_RATE, 0);
                                Projectile projectile = new Projectile(body, animation, image, false);
                                cast.AddActor(Constants.PROJECTILE_GROUP, projectile);
                                turret.ResetCountdown();

                            }
                        }
                        turret.CountDown();
                    }
                }
            }
        }
    }
}