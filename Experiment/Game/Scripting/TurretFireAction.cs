using System;
using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    public class TurretFireAction : Action
    {

        public TurretFireAction(AudioService audioService)
        {

        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            foreach(Turret turret in cast.GetActors(Constants.TURRET_GROUP))
            {
                if(turret.ShouldFire())
                {
                    Console.WriteLine("success");
                    turret.ResetCountdown();
                }
                turret.CountDown();
            }
            
        }   

    }

}