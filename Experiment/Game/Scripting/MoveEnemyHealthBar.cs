using Unit06.Game.Casting;
namespace Unit06.Game.Scripting
{
    public class MoveEnemyHealthBar : Action
    {
        public MoveEnemyHealthBar()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            foreach(Actor actor in cast.GetActors(Constants.ENEMY_HEALTH_GROUP))
            {
            Label label = (Label)actor;
            Text text = label.GetText();
            Point position = label.GetPosition();
            Point velocity = label.GetVelocity();
            position = position.Add(velocity);
            label.SetPosition(position);
            }
        }
    }
}