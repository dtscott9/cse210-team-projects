using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CollideTowerAction : Action
    {
        private AudioService audioService;
        private PhysicsService physicsService;
        
        public CollideTowerAction(PhysicsService physicsService, AudioService audioService)
        {
            this.physicsService = physicsService;
            this.audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Label label = (Label)cast.GetFirstActor(Constants.ENEMY_HEALTH_GROUP);
            Tower tower = (Tower)cast.GetFirstActor(Constants.TOWER_GROUP);
            foreach(Enemy enemy in cast.GetActors(Constants.ENEMY_GROUP))
            {
                Body enemyBody = enemy.GetBody();
                Body towerBody = tower.GetBody();

                if (physicsService.HasCollided(enemyBody, towerBody))
                {
                 cast.RemoveActor(Constants.ENEMY_HEALTH_GROUP, label);
                    int health = tower.GetHealth();
                    int damage = enemy.GetDamageDealt();
                    
                    tower.TakeDamage(damage);

                    
                    cast.RemoveActor(Constants.ENEMY_GROUP, enemy);
                    
                    

                    if (health == 10)
                    {
                        callback.OnNext(Constants.GAME_OVER);

                    }
                }
            }
        }
    }
}