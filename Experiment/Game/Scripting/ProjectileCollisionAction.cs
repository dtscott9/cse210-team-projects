using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class TowerCollision : Action
    {
        private AudioService audioService;
        private PhysicsService physicsService;

        public TowerCollision(PhysicsService physicsService, AudioService audioService)
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

                    if (physicsService.HasCollided(enemyBody, proBody))
                    {
                        int health = enemy.GetHealth();
                        int damage = enemy.GetDamageDealt();

                        enemy.TakeDamage(damage);

                        cast.RemoveActor(Constants.PROJECTILE_GROUP, projectile);

                        if (health == 0)
                        {
                            cast.RemoveActor(Constants.ENEMY_GROUP, enemy);
                        }
                    }
                }
            }
        }
    }
}