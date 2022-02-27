
using System.Collections.Generic;
using System.IO;
using System.Linq;
using unit04_greed.Game.Casting;
using unit04_greed.Directing;
using unit04_greed.Services;
using System;

namespace unit04_greed
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        private static int FRAME_RATE = 12;
        private static int MAX_X = 900;
        private static int MAX_Y = 600;
        private static int CELL_SIZE = 15;
        private static int FONT_SIZE = 25;
        private static int COLS = 60;
        private static string CAPTION = "Greed";

        private static string gem = "*";
        private static string rock = "o";

        
    
        private static Color WHITE = new Color(255, 255, 255);
        private static int DEFAULT_ARTIFACTS = 15;


        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            ScoreBoard score = new ScoreBoard();
            int Score = score.GetScore();
            // create the cast
            Cast cast = new Cast();

            // create the robot
            Actor robot = new Actor();
            robot.SetText("#");
            robot.SetFontSize(FONT_SIZE);
            robot.SetColor(WHITE);
            robot.SetPosition(new Point(MAX_X / 2, 575));
            cast.AddActor("robot", robot);

            score.SetText($"Score: {Score}");
            score.SetFontSize(20);
            score.SetColor(WHITE);
            score.SetPosition(new Point(10, 10));
            cast.AddActor("score", score);

            for (int i = 0; i < DEFAULT_ARTIFACTS; i++)
            {
                Artifact Gem = new Artifact();
                Artifact Rock = new Artifact();
                Gem.makeGem(COLS, CELL_SIZE, FONT_SIZE, gem);
                Gem.objectFalling();
                Rock.makeGem(COLS, CELL_SIZE, FONT_SIZE, rock);
                Rock.objectFalling();
                cast.AddActor("artifacts", Gem);
                cast.AddActor("artifacts", Rock);
                
            }

            
               

            

            // start the game
            KeyboardService keyboardService = new KeyboardService(CELL_SIZE);
            VideoService videoService 
                = new VideoService(CAPTION, MAX_X, MAX_Y, CELL_SIZE, FRAME_RATE, false);
            Director director = new Director(keyboardService, videoService);
               if (director.status == false)
            {
              score.AddScore();
            }
            director.StartGame(cast);
         
            // test comment
        }
    }
}
        