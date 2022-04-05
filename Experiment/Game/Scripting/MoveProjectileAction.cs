using Unit06.Game.Casting;
namespace Unit06.Game.Scripting
{
    public class MoveProjectileAction : Action
    {
        private string turrets = Constants.PROJECTILE_GROUP;
        private string lazer_turrets = Constants.PROJECTILE_GROUP_2;
        private string plasma_turrets = Constants.PROJECTILE_GROUP_3;
        public MoveProjectileAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            ProMove(cast, turrets);
            ProMove(cast, lazer_turrets);
            ProMove(cast, plasma_turrets);
        }

        public void ProMove(Cast cast, string constants) 
        {
            foreach(Projectile projectile in cast.GetActors(constants))
            {
            Body body = projectile.GetBody();
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();
            position = position.Add(velocity);
            body.SetPosition(position);
            }
        }
    }
}