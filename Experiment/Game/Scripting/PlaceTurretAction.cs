using System;
using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    public class PlaceTurret : Action
    {
        private AudioService audioService;
        private MouseService mouseService;

        public PlaceTurret(MouseService mouseService, AudioService audioService)
        {
            this.mouseService = mouseService;
            this.audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Point mouseCor = mouseService.GetCoordinates();
            int mouseX = mouseCor.GetX() - 25;
            int mouseY = mouseCor.GetY();
            bool placeTurretBool = true;

            foreach (Turret turret in cast.GetActors(Constants.TURRET_GROUP))
            {
                Body body = turret.GetBody();
                Point turretPosition = body.GetPosition();
                int turretX = turretPosition.GetX();
                if (Math.Abs(turretX - mouseX) <= 30)
                {
                    placeTurretBool = false;
                }
            }
            if (placeTurretBool)
            {
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
                                image = Constants.TURRET_IMAGE_UP;
                            }
                            int cost = 100;
                            Point position = new Point(mouseX, mouseY);
                            Point size = new Point(Constants.TURRET_WIDTH, Constants.TURRET_HEIGHT);
                            Point velocity = new Point(0, 0);

                            Body body = new Body(position, size, velocity);

                            Turret turret = new Turret(body, image, false);
                            cast.AddActor(Constants.TURRET_GROUP, turret);
                            Sound sound = new Sound(Constants.PURCHASE_SOUND);
                            audioService.PlaySound(sound);

                            stats.SubtractGold(cost);
                        }
                    }
                }
            }
        }
    }
}