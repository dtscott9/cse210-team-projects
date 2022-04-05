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

            Tower tower = (Tower)cast.GetFirstActor(Constants.TOWER_GROUP);
            foreach (Enemy enemy in cast.GetActors(Constants.ENEMY_GROUP))
            {
                Body enemyBody = enemy.GetBody();
                Body towerBody = tower.GetBody();

                if (physicsService.HasCollided(enemyBody, towerBody))
                {
                    int health = tower.GetHealth();
                    int damage = enemy.GetDamageDealt();
                    Sound sound = new Sound(Constants.EXPLOSION_SOUND);
                    audioService.PlaySound(sound);

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