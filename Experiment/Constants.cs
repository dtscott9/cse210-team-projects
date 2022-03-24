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

        // FIELD
        public static int FIELD_TOP = 60;
        public static int FIELD_BOTTOM = SCREEN_HEIGHT;
        public static int FIELD_LEFT = 0;
        public static int FIELD_RIGHT = SCREEN_WIDTH;

        // FONT
        public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        public static int FONT_SIZE = 32;

        // SOUND
        public static string BOUNCE_SOUND = "Assets/Sounds/boing.wav";
        public static string WELCOME_SOUND = "Assets/Sounds/start.wav";
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
        public static string SCORE_GROUP = "score";
        public static string LEVEL_FORMAT = "WAVE: {0}";
        public static string SCORE_FORMAT = "GOLD: {0}";

        // TURRET
        public static string TURRET_GROUP = "turrets";
        public static string TURRET_IMAGE = "Assets/Images/000.png";
        public static int TURRET_WIDTH = 28;
        public static int TURRET_HEIGHT = 28;
        public static int TURRET_VELOCITY = 6;
        public static int TURRET_COUNT = 3;

        // TOWER
        public static string TOWER_GROUP = "towers";
        public static string TOWER_IMAGE = "";
        public static int TOWER_WIDTH = 30;
        public static int TOWER_HEIGHT = 381;
        public static string TOWER_HEALTH_GROUP = "tower_health";
        public static string TOWER_HEALTH_FORMAT = "HEALTH: {0}/100";

        // WALL
        public static string WALL_GROUP = "walls";
        public static string WALL_IMAGE = " ";
        public static int WALL_WIDTH = Constants.SCREEN_WIDTH;
        public static int WALL_HEIGHT = 150;

        // ENEMY
        public static string ENEMY_GROUP = "enemies";
        public static string ENEMY_IMAGE = "";
        public static int ENEMY_WIDTH = 50;
        public static int ENEMY_HEIGHT = 60;
        public static int ENEMY_WAVE_1 = 10;
        public static int ENEMY_HEALTH = 20;
        public static string ENEMY_HEALTH_GROUP = "enemy_health";
        public static string ENEMY_HEALTH_FORMAT = "{0}/20";


        // DIALOG
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START";
        public static string PREP_TO_LAUNCH = "DEFEND THE TOWER!";
        public static string WAS_GOOD_GAME = "TOWER DESTROYED \n GAME OVER";

    }
}