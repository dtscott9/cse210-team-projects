using System;
using System.Linq;
using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    public class ProjectileFireAction : Action
    {

        private string turretGroup = Constants.TURRET_GROUP;
        private string lazerGroup = Constants.LAZER_GROUP;
        private string plasmaGroup = Constants.PLASMA_GROUP;
        public ProjectileFireAction(AudioService audioService)
        {
        }

        public async void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Enemy enemy = (Enemy)cast.GetFirstActor(Constants.ENEMY_GROUP);
            Body eBody = enemy.GetBody();
            Point ePosition = eBody.GetPosition();
            TurretFire(cast, ePosition);
            LazerFire(cast, ePosition);
            PlasmaFire(cast, ePosition);
        }
        public void TurretFire(Cast cast, Point ePos)
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


                    if (turret.ShouldFireBullet())
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
                        int velocityX = ePos.GetX() / Constants.TURRET_VELOCITY;
                        int velocityY = ePos.GetY() / Constants.TURRET_VELOCITY;
                        Point velocity = new Point((velocityX - velx) + 2, velocityY - vely);

                        Body body = new Body(position, size, velocity);
                        Image image = new Image(Constants.PROJECTILE_IMAGE);
                        Animation animation = new Animation(Constants.PROJECTILE_IMAGES_1, Constants.PROJECTILE_RATE, 0);
                        Projectile projectile = new Projectile(body, animation, image, false);
                        cast.AddActor(Constants.PROJECTILE_GROUP, projectile);
                        turret.ResetBulletCountdown();
                    }
                    turret.CountDown();
                }
            }
        }
        public void LazerFire(Cast cast, Point ePos)
        {
            foreach (Turret turret in cast.GetActors(Constants.LAZER_GROUP))
            {

                if (cast.GetActors(Constants.ENEMY_GROUP).Count > 0)
                {
                    Body Tbody = turret.GetBody();
                    Point tPosition = Tbody.GetPosition();
                    int tX = tPosition.GetX();
                    int tY = tPosition.GetY();
                    int velx = tPosition.GetX() / Constants.TURRET_VELOCITY;
                    int vely = tPosition.GetY() / Constants.TURRET_VELOCITY;


                    if (turret.ShouldFireLazer())
                    {
                        Console.WriteLine("Imma firing my lazer!");
                        if (tY <= 340)
                        {
                            tY += 35;
                            tX += 9;
                            vely = 2;
                        }

                        else
                        {
                            tY -= 70;
                            tX += 10;
                            vely = -2;
                        }
                        Point position = new Point(tX, tY);
                        Point size = new Point(Constants.LAZER_PRO_WIDTH, Constants.LAZER_PRO_HEIGHT);
                        int velocityX = ePos.GetX() / Constants.TURRET_VELOCITY;
                        int velocityY = ePos.GetY() / Constants.TURRET_VELOCITY;
                        Point velocity = new Point(0, vely);

                        Body body = new Body(position, size, velocity);
                        Image image = new Image(Constants.PROJECTILE_IMAGE);
                        Animation animation = new Animation(Constants.PROJECTILE_IMAGES_2, Constants.PROJECTILE_RATE, 0);
                        Projectile projectile = new Projectile(body, animation, image, false);
                        cast.AddActor(Constants.PROJECTILE_GROUP, projectile);
                        turret.ResetLazerCountdown();
                    }
                    turret.CountDown();
                }
            }
        }
        public void PlasmaFire(Cast cast, Point ePos)
        {
            foreach (Turret turret in cast.GetActors(Constants.PLASMA_GROUP))
            {

                if (cast.GetActors(Constants.ENEMY_GROUP).Count > 0)
                {
                    Body Tbody = turret.GetBody();
                    Point tPosition = Tbody.GetPosition();
                    int tX = tPosition.GetX();
                    int tY = tPosition.GetY();
                    int velx = tPosition.GetX() / Constants.TURRET_VELOCITY;
                    int vely = tPosition.GetY() / Constants.TURRET_VELOCITY;


                    if (turret.ShouldFirePlasma())
                    {
                        Console.WriteLine("BWAAAA!");
                        if (tY <= 340)
                        {
                            tY += 30;
                 
                        }

                        else
                        {
                            tY -= 15;
                        }
                        Point position = new Point(tX, tY);
                        Point size = new Point(Constants.PLASMA_PRO_WIDTH, Constants.PLASMA_PRO_HEIGHT);
                        int velocityX = ePos.GetX() / Constants.TURRET_VELOCITY;
                        int velocityY = ePos.GetY() / Constants.TURRET_VELOCITY;
                        Point velocity = new Point((velocityX - velx) + 2, velocityY - vely);

                        Body body = new Body(position, size, velocity);
                        Image image = new Image(Constants.PROJECTILE_IMAGE);
                        Animation animation = new Animation(Constants.PROJECTILE_IMAGES_3, Constants.PROJECTILE_RATE, 0);
                        Projectile projectile = new Projectile(body, animation, image, false);
                        cast.AddActor(Constants.PROJECTILE_GROUP, projectile);
                        turret.ResetPlasmaCountdown();
                    }
                    turret.CountDown();
                }
            }
        }
    }
}