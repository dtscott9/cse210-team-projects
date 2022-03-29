using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CollideBulletAction : Action
    {
        private AudioService audioService;
        private PhysicsService physicsService;

        public CollideBulletAction(PhysicsService physicsService, AudioService audioService)
        {
            this.physicsService = physicsService;
            this.audioService = audioService;
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