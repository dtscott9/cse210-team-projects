using Unit06.Game.Casting;

namespace Unit06.Game.Scripting
{
    public class MoveEnemyAction : Action
    {
        public MoveEnemyAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Enemy enemy = (Enemy)cast.GetFirstActor(Constants.ENEMY_GROUP);
            Body body = enemy.GetBody();
            Point position = body.GetPosition();
            Point velocity = body.GetVelocity();
            int x = position.GetX();

            position = position.Add(velocity);
            if (x < 0)
            {
                position = new Point(0, position.GetY());
            }
            else if (x > Constants.SCREEN_WIDTH - Constants.ENEMY_WIDTH)
            {
                position = new Point(Constants.SCREEN_WIDTH - Constants.ENEMY_WIDTH, 
                    position.GetY());
            }

            body.SetPosition(position);  
        }
    }
}