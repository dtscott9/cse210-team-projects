using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CollideBulletAction : Action
    {
        private AudioService audioService;
        private PhysicsService physicsService;
        private VideoService videoService;

        public CollideBulletAction(PhysicsService physicsService, AudioService audioService, VideoService videoService)
        {
            this.physicsService = physicsService;
            this.audioService = audioService;
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            foreach (Projectile projectile in cast.GetActors(Constants.PROJECTILE_GROUP))
            {
                foreach (Enemy enemy in cast.GetActors(Constants.ENEMY_GROUP))
                {
                    Body enemyBody = enemy.GetBody();
                    Body proBody = projectile.GetBody();
                    Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                    if (physicsService.HasCollided(enemyBody, proBody))
                    {
                        int health = enemy.GetHealth();
                        int damage = enemy.GetDamageDealt();
                        int gold = enemy.GetGoldDropped();
                        enemy.TakeDamage(damage);


                        // videoService.DrawImage(image, proPosition);

                        // // Animation animation = new Animation(Constants.PROJECTILE_IMAGES_1, Constants.PROJECTILE_RATE, 0);
                        // // Projectile projectile1 = new Projectile(proBody, animation, projectile.GetImage());
                        // Animation animation = proBody.GetAnimation();
                        // Image image = animation.NextImage();
                        // Point proPosition = proBody.GetPosition();
                        // Point size = new Point(Constants.PROJECTILE_WIDTH, Constants.PROJECTILE_HEIGHT);


                        // Body body = new Body(proPosition, size, );
                        // // Image image = new Image(Constants.PROJECTILE_IMAGE);
                        // Animation animation = new Animation(Constants.PROJECTILE_IMAGES_1, Constants.PROJECTILE_RATE, 0);
                        // Projectile projectile = new Projectile(body, animation, image, false);

                        // cast.AddActor(Constants.RACKET_GROUP, racket);
                        // cast.AddActor(Constants.PROJECTILE_GROUP, projectile1);
                        cast.RemoveActor(Constants.PROJECTILE_GROUP, projectile);

                        if (health == 10)
                        {
                            cast.RemoveActor(Constants.ENEMY_GROUP, enemy);
                            stats.AddGold(gold);
                        }
                    }
                }
            }
        }
    }
}