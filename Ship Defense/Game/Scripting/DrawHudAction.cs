using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawHudAction : Action
    {
        private VideoService videoService;
        
        public DrawHudAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
            Tower tower = (Tower)cast.GetFirstActor(Constants.TOWER_GROUP);
            DrawLabel(cast, Constants.LEVEL_GROUP, Constants.LEVEL_FORMAT, stats.GetLevel());
            DrawLabel(cast, Constants.GOLD_GROUP, Constants.GOLD_FORMAT, stats.GetGoldCount());
            DrawLabel(cast, Constants.TOWER_HEALTH_GROUP, Constants.TOWER_HEALTH_FORMAT, tower.GetHealth());
            // DrawLabel(cast, Constants.ENEMY_HEALTH_GROUP, Constants.ENEMY_HEALTH_FORMAT, enemy.GetHealth());
        }

        // **********************************************************************************************
        // You found the bug. Great job!
        // **********************************************************************************************
        // todo: fix the bug by making sure the text value is set to the appropriate variable.
        private void DrawLabel(Cast cast, string group, string format, int data)
        {
            string theValueToDisplay = string.Format(format, data);
            
            Label label = (Label)cast.GetFirstActor(group);
            Text text = label.GetText();
            text.SetValue(string.Format(format, data));
            Point position = label.GetPosition();
            videoService.DrawText(text, position);
        }
    }
}