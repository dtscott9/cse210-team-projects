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
                if (mouseY >= Constants.TURRET_PLACEMENT_Y_1 && mouseY <= Constants.TURRET_PLACEMENT_Y_1 + 45
                || mouseY <= Constants.TURRET_PLACEMENT_Y_2 && mouseY >= Constants.TURRET_PLACEMENT_Y_2 - 45
                || mouseY >= Constants.TURRET_PLACEMENT_Y_2 && mouseY <= Constants.TURRET_PLACEMENT_Y_2 + 45)
                {
                    if (AvailableGold >= 100)
                    {
                        Image image = Constants.TURRET_IMAGE_DOWN;
                        if (mouseY <= 340)
                        {
                            mouseY = Constants.TURRET_PLACEMENT_Y_1;
                            image = Constants.TURRET_IMAGE_DOWN;
                        }
                        else
                        {
                            mouseY = Constants.TURRET_PLACEMENT_Y_2;
                            image = Constants.TURRET_IMAGE_DOWN;
                        }
                        int cost = 100;
                        Point position = new Point(mouseX, mouseY);
                        Point size = new Point(Constants.TURRET_WIDTH, Constants.TURRET_HEIGHT);
                        Point velocity = new Point(0, 0);

                        Body body = new Body(position, size, velocity);
                        
                        Turret turret = new Turret(body, image, false);
                        cast.AddActor(Constants.TURRET_GROUP, turret);
                        stats.SubtractGold(cost);
                    }
                }
            }
        }
    }
}