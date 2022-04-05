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
        private string turrets = Constants.PROJECTILE_GROUP;
        private string lazer_turrets = Constants.PROJECTILE_GROUP_2;
        private string plasma_turrets = Constants.PROJECTILE_GROUP_3;
        private int plasma_Enemy_H = 20;
        private int turret_Enemy_H = 10;

        public CollideBulletAction(PhysicsService physicsService, AudioService audioService, VideoService videoService)
        {
            this.physicsService = physicsService;
            this.audioService = audioService;
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            ProCollision(cast, turrets, Constants.PROJECTILE_DMG, turret_Enemy_H);
            ProCollision(cast, lazer_turrets, Constants.PROJECTILE_DMG, turret_Enemy_H);
            ProCollision(cast, plasma_turrets, Constants.PLASMA_DMG, plasma_Enemy_H);
        }
        public void ProCollision(Cast cast, string constants, int damage, int re_health)
        {
            foreach (Projectile projectile in cast.GetActors(constants))
            {
                Body proBody = projectile.GetBody();

                foreach (Enemy enemy in cast.GetActors(Constants.ENEMY_GROUP))
                {
                    Body enemyBody = enemy.GetBody();

                    Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                    if (physicsService.HasCollided(enemyBody, proBody))
                    {
                        int health = enemy.GetHealth();
                        int gold = enemy.GetGoldDropped();
                        enemy.TakeDamage(damage);

                        cast.RemoveActor(constants, projectile);

                        if (health <= re_health)
                        {
                            cast.RemoveActor(Constants.ENEMY_GROUP, enemy);
                            Sound sound = new Sound(Constants.EXPLOSION_SOUND);
                            audioService.PlaySound(sound);
                            stats.AddGold(gold);
                        }
                    }
                }
            }
        }
    }
}