using Unit06.Game.Casting;
namespace Unit06.Game.Scripting
{
    public class MoveBallAction : Action
    {
        public MoveBallAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Turret ball = (Turret)cast.GetFirstActor(Constants.TURRET_GROUP);
            Body body = ball.GetBody();
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();
            position = position.Add(velocity);
            body.SetPosition(position);
        }
    }
}