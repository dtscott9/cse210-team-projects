using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class CheckOverAction : Action
    {
        public CheckOverAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            
            if (cast.GetActors(Constants.ENEMY_GROUP).Count == 0)
            {
                Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                stats.AddLevel();
                stats.AddEnemyWave();
                callback.OnNext(Constants.NEXT_LEVEL);
            }
        }
    }
}