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
        private int turretCost = 100;
        private int lazerCost = 1000;
        private int plasmaCost = 10000;


        public PlaceTurret(MouseService mouseService, AudioService audioService)
        {
            this.mouseService = mouseService;
            this.audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
            int AvailableGold = stats.GetGoldCount();
            Point mouseCor = mouseService.GetCoordinates();
            int mouseX = mouseCor.GetX() - 25;
            int mouseY = mouseCor.GetY();
            Button button = (Button)cast.GetFirstActor(Constants.BUTTON_GROUP);
            Body bBody = button.GetBody();
            Point butPos = bBody.GetPosition();
            int buttonX = butPos.GetX();
            int buttonY = butPos.GetY();
            Point position = new Point(Constants.WALL_TOP_X, Constants.WALL_TOP_Y);
            Point size = new Point(Constants.WALL_WIDTH, Constants.WALL_HEIGHT);
            Point velocity = new Point(0, 0);
            Animation animation = new Animation(Constants.IDLE_TOP_1, 8, 0);
            Body body = new Body(position, size, velocity);
            Wall idle = new Wall(body, animation, false);
           

            if (mouseY >= 0 && mouseY <= 50 && mouseX >= 125 && mouseX <= 200)

            {
                if (mouseService.IsButtonReleased(Constants.LEFT))
                    if (AvailableGold >= turretCost)
                    {

                        {
                            placeTurret = true;
                            Console.WriteLine("Button1 Clicked");
                            cast.AddActor(Constants.WALL_GROUP, idle);
                            stats.SubtractGold(turretCost);

                        }
                    }
            }

            else if (mouseY >= 0 && mouseY <= 50 && mouseX >= 175 && mouseX <= 250)
            {
                if (mouseService.IsButtonReleased(Constants.LEFT))
                    if (AvailableGold >= lazerCost)
                    {
                        {
                            placeLazer = true;
                            Console.WriteLine("Button2 Clicked");
                            stats.SubtractGold(lazerCost);
                        }
                    }
            }
            else if (mouseY >= 0 && mouseY <= 50 && mouseX >= 225 && mouseX <= 325)
            {
                if (mouseService.IsButtonReleased(Constants.LEFT))
                {
                    if (AvailableGold >= plasmaCost)
                    {
                        placePlasma = true;
                        Console.WriteLine("Button3 Clicked");
                        stats.SubtractGold(plasmaCost);
                    }
                }
            }

            TurretPlace(cast, mouseY, mouseX);
            
            cast.RemoveActor(Constants.WALL_GROUP, idle);
            LazerPlace(cast, mouseY, mouseX);
            PlasmaPlace(cast, mouseY, mouseX);
        }

        public void TurretPlace(Cast cast, int mouseY, int mouseX)
        {
            if (mouseService.IsButtonReleased(Constants.LEFT))
            {

                if (mouseY >= Constants.TURRET_PLACEMENT_Y_1 && mouseY <= Constants.TURRET_PLACEMENT_Y_1 + 45
                || mouseY <= Constants.TURRET_PLACEMENT_Y_2 && mouseY >= Constants.TURRET_PLACEMENT_Y_2 - 45
                || mouseY >= Constants.TURRET_PLACEMENT_Y_2 && mouseY <= Constants.TURRET_PLACEMENT_Y_2 + 45)
                {
                    if (placeTurret == true)
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
                        Point position = new Point(mouseX, mouseY);
                        Point size = new Point(Constants.TURRET_WIDTH, Constants.TURRET_HEIGHT);
                        Point velocity = new Point(0, 0);
                        Body body = new Body(position, size, velocity);
                        Turret turret = new Turret(body, image, false);
                        cast.AddActor(Constants.TURRET_GROUP, turret);
                        Sound sound = new Sound(Constants.PURCHASE_SOUND);
                        audioService.PlaySound(sound);

                        placeTurret = false;
                    }
                }
            }
        }
        public void LazerPlace(Cast cast, int mouseY, int mouseX)
        {
            if (mouseService.IsButtonReleased(Constants.LEFT))
            {

                if (mouseY >= Constants.TURRET_PLACEMENT_Y_1 && mouseY <= Constants.TURRET_PLACEMENT_Y_1 + 45
                || mouseY <= Constants.TURRET_PLACEMENT_Y_2 && mouseY >= Constants.TURRET_PLACEMENT_Y_2 - 45
                || mouseY >= Constants.TURRET_PLACEMENT_Y_2 && mouseY <= Constants.TURRET_PLACEMENT_Y_2 + 45)
                {
                    if (placeLazer == true)
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

                        Point position = new Point(mouseX, mouseY);
                        Point size = new Point(Constants.LAZER_WIDTH, Constants.LAZER_HEIGHT);
                        Point velocity = new Point(0, 0);

                        Body body = new Body(position, size, velocity);

                        Turret lazer = new Turret(body, image, false);
                        cast.AddActor(Constants.LAZER_GROUP, lazer);
                        Sound sound = new Sound(Constants.PURCHASE_SOUND);
                        audioService.PlaySound(sound);

                        placeLazer = false;

                    }
                }
            }
        }
        public void PlasmaPlace(Cast cast, int mouseY, int mouseX)
        {
            if (mouseService.IsButtonReleased(Constants.LEFT))
            {


                if (mouseY >= Constants.TURRET_PLACEMENT_Y_1 && mouseY <= Constants.TURRET_PLACEMENT_Y_1 + 45
                || mouseY <= Constants.TURRET_PLACEMENT_Y_2 && mouseY >= Constants.TURRET_PLACEMENT_Y_2 - 45
                || mouseY >= Constants.TURRET_PLACEMENT_Y_2 && mouseY <= Constants.TURRET_PLACEMENT_Y_2 + 45)
                {
                    if (placePlasma == true)
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

                        Point position = new Point(mouseX, mouseY);
                        Point size = new Point(Constants.TURRET_WIDTH, Constants.TURRET_HEIGHT);
                        Point velocity = new Point(0, 0);

                        Body body = new Body(position, size, velocity);

                        Turret turret = new Turret(body, image, false);
                        cast.AddActor(Constants.PLASMA_GROUP, turret);
                        Sound sound = new Sound(Constants.PURCHASE_SOUND);
                        audioService.PlaySound(sound);

                        placePlasma = false;
                    }
                }
            }
        }
    }
}