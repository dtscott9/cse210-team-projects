using Unit06.Game.Casting;
namespace Unit06.Game.Scripting
{
    public class MoveProjectileAction : Action
    {
        public MoveProjectileAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            foreach(Projectile projectile in cast.GetActors(Constants.PROJECTILE_GROUP))
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