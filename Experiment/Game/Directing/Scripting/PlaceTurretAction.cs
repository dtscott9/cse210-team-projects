using System;
using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    public class PlaceTurret : Action
    {
        private VideoService videoService;
        private MouseService mouseService;

        public PlaceTurret(MouseService mouseService)
        {
            this.mouseService = mouseService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Point mouseCor = mouseService.GetCoordinates();
            int mouseX = mouseCor.GetX();
            int mouseY = mouseCor.GetY();
            Random random1 = new Random();
            Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
            int AvailableGold = stats.GetGoldCount();
            if (mouseService.IsButtonReleased(Constants.LEFT))
            {
                if (mouseY >= Constants.TOWER_PLACEMENT_Y_1 && mouseY <= Constants.TOWER_PLACEMENT_Y_1 + 20
                || mouseY <= Constants.TOWER_PLACEMENT_Y_2 && mouseY >= Constants.TOWER_PLACEMENT_Y_2 - 20
                || mouseY >= Constants.TOWER_PLACEMENT_Y_2 && mouseY <= Constants.TOWER_PLACEMENT_Y_2 + 20)
                {
                    if (AvailableGold >= 100)
                    {
                        if (mouseY <= 340)
                        {
                            mouseY = Constants.TOWER_PLACEMENT_Y_1;
                        }
                        else
                        {
                            mouseY = Constants.TOWER_PLACEMENT_Y_2;
                        }
                        int cost = 100;
                        Point position = new Point(mouseX, mouseY);
                        Point size = new Point(Constants.TURRET_WIDTH, Constants.TURRET_HEIGHT);
                        Point velocity = new Point(0, 0);

                        Body body = new Body(position, size, velocity);
                        Image image = new Image(Constants.TURRET_IMAGE);
                        Turret turret = new Turret(body, image, false);
                        cast.AddActor(Constants.TURRET_GROUP, turret);
                        stats.SubtractGold(cost);
                    }
                }
            }
        }
    }
}