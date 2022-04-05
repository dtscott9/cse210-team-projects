using System;
using System.Windows.Input;
using Unit06.Game.Casting;
using Unit06.Game.Services;

namespace Unit06.Game.Scripting
{
    public class PlaceTurret : Action
    {
        private AudioService audioService;
        private MouseService mouseService;
        private bool placeTurret = false;
        private bool placeLazer = false;
        private bool placePlasma = false;


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
            Button button = (Button)cast.GetFirstActor(Constants.BUTTON_GROUP);
            Body bBody = button.GetBody();
            Point butPos = bBody.GetPosition();
            int buttonX = butPos.GetX();
            int buttonY = butPos.GetY();


            if (mouseY >= 0 && mouseY <= 50 && mouseX >= 125 && mouseX <= 200)

            {
                if (mouseService.IsButtonReleased(Constants.LEFT))

                {
                    placeTurret = true;
                    Console.WriteLine("Button1 Clicked");
                }
            }

            else if (mouseY >= 0 && mouseY <= 50 && mouseX >= 175 && mouseX <= 250)
            {
                if (mouseService.IsButtonReleased(Constants.LEFT))
                {
                    placeLazer = true;
                    Console.WriteLine("Button2 Clicked");
                }
            }
            else if (mouseY >= 0 && mouseY <= 50 && mouseX >= 225 && mouseX <= 325)
            {
                if (mouseService.IsButtonReleased(Constants.LEFT))
                {
                    placePlasma = true;
                    Console.WriteLine("Button3 Clicked");
                }
            }

            TurretPlace(cast, mouseY, mouseX);
            LazerPlace(cast, mouseY, mouseX);
            PlasmaPlace(cast, mouseY, mouseX);
        }

        public void TurretPlace(Cast cast, int mouseY, int mouseX)
        {
            if (mouseService.IsButtonReleased(Constants.LEFT))
            {
                Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                int AvailableGold = stats.GetGoldCount();

                if (mouseY >= Constants.TURRET_PLACEMENT_Y_1 && mouseY <= Constants.TURRET_PLACEMENT_Y_1 + 45
                || mouseY <= Constants.TURRET_PLACEMENT_Y_2 && mouseY >= Constants.TURRET_PLACEMENT_Y_2 - 45
                || mouseY >= Constants.TURRET_PLACEMENT_Y_2 && mouseY <= Constants.TURRET_PLACEMENT_Y_2 + 45)
                {
                    if (placeTurret == true)
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

                            placeTurret = false;
                        }
                    }
                }
            }
        }
        public void LazerPlace(Cast cast, int mouseY, int mouseX)
        {
            if (mouseService.IsButtonReleased(Constants.LEFT))
            {
                Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                int AvailableGold = stats.GetGoldCount();

                if (mouseY >= Constants.TURRET_PLACEMENT_Y_1 && mouseY <= Constants.TURRET_PLACEMENT_Y_1 + 45
                || mouseY <= Constants.TURRET_PLACEMENT_Y_2 && mouseY >= Constants.TURRET_PLACEMENT_Y_2 - 45
                || mouseY >= Constants.TURRET_PLACEMENT_Y_2 && mouseY <= Constants.TURRET_PLACEMENT_Y_2 + 45)
                {
                    if (placeLazer == true)
                    {
                        if (AvailableGold >= 100)
                        {
                            Image image = Constants.LAZER_IMAGE_DOWN;
                            if (mouseY <= 340)
                            {
                                mouseY = Constants.TURRET_PLACEMENT_Y_1;
                                image = Constants.LAZER_IMAGE_DOWN;
                            }
                            else
                            {
                                mouseY = Constants.TURRET_PLACEMENT_Y_2;
                                image = Constants.LAZER_IMAGE_UP;
                            }
                            int cost = 100;
                            Point position = new Point(mouseX, mouseY);
                            Point size = new Point(Constants.LAZER_WIDTH, Constants.LAZER_HEIGHT);
                            Point velocity = new Point(0, 0);

                            Body body = new Body(position, size, velocity);

                            Turret lazer = new Turret(body, image, false);
                            cast.AddActor(Constants.LAZER_GROUP, lazer);
                            Sound sound = new Sound(Constants.PURCHASE_SOUND);
                            audioService.PlaySound(sound);

                            stats.SubtractGold(cost);

                            placeLazer = false;
                        }
                    }
                }
            }
        }
        public void PlasmaPlace(Cast cast, int mouseY, int mouseX)
        {
            if (mouseService.IsButtonReleased(Constants.LEFT))
            {
                Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                int AvailableGold = stats.GetGoldCount();

                if (mouseY >= Constants.TURRET_PLACEMENT_Y_1 && mouseY <= Constants.TURRET_PLACEMENT_Y_1 + 45
                || mouseY <= Constants.TURRET_PLACEMENT_Y_2 && mouseY >= Constants.TURRET_PLACEMENT_Y_2 - 45
                || mouseY >= Constants.TURRET_PLACEMENT_Y_2 && mouseY <= Constants.TURRET_PLACEMENT_Y_2 + 45)
                {
                    if (placePlasma == true)
                    {
                        if (AvailableGold >= 100)
                        {
                            Image image = Constants.PLASMA_IMAGE_DOWN;
                            if (mouseY <= 340)
                            {
                                mouseY = Constants.TURRET_PLACEMENT_Y_1;
                                image = Constants.PLASMA_IMAGE_DOWN;
                            }
                            else
                            {
                                mouseY = Constants.TURRET_PLACEMENT_Y_2;
                                image = Constants.PLASMA_IMAGE_UP;
                            }
                            int cost = 100;
                            Point position = new Point(mouseX, mouseY);
                            Point size = new Point(Constants.TURRET_WIDTH, Constants.TURRET_HEIGHT);
                            Point velocity = new Point(0, 0);

                            Body body = new Body(position, size, velocity);

                            Turret turret = new Turret(body, image, false);
                            cast.AddActor(Constants.PLASMA_GROUP, turret);
                            Sound sound = new Sound(Constants.PURCHASE_SOUND);
                            audioService.PlaySound(sound);

                            stats.SubtractGold(cost);

                            placePlasma = false;
                        }
                    }
                }
            }
        }
    }
}