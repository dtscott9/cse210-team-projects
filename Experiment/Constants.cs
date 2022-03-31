using System.Collections.Generic;
using Unit06.Game.Casting;


namespace Unit06
{
    public class Constants
    {
        // ----------------------------------------------------------------------------------------- 
        // GENERAL GAME CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // GAME
        public static string GAME_NAME = "TOWER DEFENSE";
        public static int FRAME_RATE = 60;

        // SCREEN
        public static int SCREEN_WIDTH = 1100;
        public static int SCREEN_HEIGHT = 680;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;
        public static Image BACKGROUND_IMAGE = new Image("Assets/Images/Background/stars_texture.png");

        // FIELD
        public static int FIELD_TOP = 60;
        public static int FIELD_BOTTOM = SCREEN_HEIGHT;
        public static int FIELD_LEFT = 0;
        public static int FIELD_RIGHT = SCREEN_WIDTH;

        // FONT
        public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        public static int FONT_SIZE = 32;

        // SOUND
        public static string EXPLOSION_SOUND = "Assets/Sounds/explosion.wav";
        public static string PURCHASE_SOUND = "Assets/Sounds/purchase.wav";
        public static string OVER_SOUND = "Assets/Sounds/over.wav";

        // TEXT
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_CENTER = 1;
        public static int ALIGN_RIGHT = 2;


        // COLORS
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);
        public static Color BLUE = new Color(0, 0, 255);
        public static Color GREEN = new Color(34,139,34);

        // KEYS
        public static string LEFT = "left";
        public static string RIGHT = "right";
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";

        // SCENES
        public static string NEW_GAME = "new_game";
        public static string TRY_AGAIN = "try_again";
        public static string NEXT_LEVEL = "next_level";
        public static string IN_PLAY = "in_play";
        public static string GAME_OVER = "game_over";

        // LEVELS
        public static string LEVEL_FILE = "Assets/Data/level-{0:000}.txt";
        public static int BASE_LEVELS = 5;

        // ----------------------------------------------------------------------------------------- 
        // SCRIPTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // PHASES
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string UPDATE = "update";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        // ----------------------------------------------------------------------------------------- 
        // CASTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // STATS
        public static string STATS_GROUP = "stats";
        public static int DEFAULT_LIVES = 3;
        public static int MAXIMUM_LIVES = 5;

        // HUD
        public static int HUD_MARGIN = 15;
        public static string LEVEL_GROUP = "level";
        public static string LIVES_GROUP = "lives";
        public static string GOLD_GROUP = "gold";
        public static string LEVEL_FORMAT = "WAVE: {0}";
        public static string GOLD_FORMAT = "GOLD: {0}";



        // TOWER
        public static string TOWER_GROUP = "towers";
        public static string TOWER_IMAGE = "";
        public static int TOWER_WIDTH = 30;
        public static int TOWER_HEIGHT = 381;
        public static string TOWER_HEALTH_GROUP = "tower_health";
        public static string TOWER_HEALTH_FORMAT = "HEALTH: {0}/100";

        // WALL
        public static string WALL_GROUP = "walls";
        public static string WALL_BOTTOM_IMAGE = "Assets/Images/Background/wall_bottom.png";
        public static string WALL_TOP_IMAGE = "Assets/Images/Background/wall_top.png";
        public static int WALL_WIDTH = Constants.SCREEN_WIDTH;
        public static int WALL_HEIGHT = 100;

         // TURRET
         
        public static string TURRET_GROUP = "turrets";
        public static Image TURRET_IMAGE_UP = new Image("Assets/Images/Weapons/Medium/Cannon/turret_01_mk1_up.png");
        public static Image TURRET_IMAGE_DOWN = new Image("Assets/Images/Weapons/Medium/Cannon/turret_01_mk1_down.png");
        
        public static int TURRET_WIDTH = 28;
        public static int TURRET_HEIGHT = 28;
        public static int TURRET_VELOCITY = 50;
        public static int TURRET_COUNT = 3;
        public static int TURRET_ONE_COUNTDOWN = 125;
        public static int TURRET_PLACEMENT_Y_1 = 90;
        public static int TURRET_PLACEMENT_Y_2 = 540;

        // ENEMY
        public static string ENEMY_GROUP = "enemies";
        public static List<string> ENEMY_IMAGES =
        new List<string>() {
            "Assets/Images/1 Drones/1/Walk_1.png",
            "Assets/Images/1 Drones/1/Walk_2.png",
            "Assets/Images/1 Drones/1/Walk_3.png",
            "Assets/Images/1 Drones/1/Walk_4.png"
            
        };
        public static int ENEMY_RATE = 6;
        public static int ENEMY_WIDTH = 50;
        public static int ENEMY_HEIGHT = 60;
        public static int ENEMY_WAVE = 10;
        public static int ENEMY_FONT_SIZE = 20;
        public static int GOLD_DROPPED = 50;

        //Projectile
        public static string PROJECTILE_GROUP = "projectile";
        public static int PROJECTILE_WIDTH = 5;
        public static int PROJECTILE_HEIGHT = 5;
        public static string PROJECTILE_IMAGE = "Assets/Images/Weapons/Small/Cannon/turret_01_bullet_01.png";
        public static List<string> PROJECTILE_IMAGES_1
            = new List<string>() {
                "Assets/Images/Weapons/Small/Cannon/bulletAnimation/bullet_1_animation_1.png",
                "Assets/Images/Weapons/Small/Cannon/bulletAnimation/bullet_1_animation_2.png",
                "Assets/Images/Weapons/Small/Cannon/bulletAnimation/bullet_1_animation_3.png",
                "Assets/Images/Weapons/Small/Cannon/bulletAnimation/bullet_1_animation_4.png",
                "Assets/Images/Weapons/Small/Cannon/bulletAnimation/bullet_1_animation_5.png",
            };
        public static int PROJECTILE_RATE = 6;
        // DIALOG
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START";
        public static string PREP_TO_LAUNCH = "DEFEND THE STATION!";
        public static string WAS_GOOD_GAME = "THE STATION HAS FALLEN \n GAME OVER";
        public static string NEW_WAVE = "NEW ENEMY WAVE INCOMING";

    }
}