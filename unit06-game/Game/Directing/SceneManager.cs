using System;
using System.Collections.Generic;
using System.IO;
using unit06_game.Game.Casting;
using unit06_game.Game.Scripting;
using unit06_game.Game.Services;


namespace unit06_game.Game.Directing
{
    public class SceneManager
    {
        public static AudioService AudioService = new RaylibAudioService();
        public static MouseService MouseService = new RaylibMouseService();
        public static PhysicsService PhysicsService = new RaylibPhysicsService();
        public static VideoService VideoService = new RaylibVideoService(Constants.GAME_NAME,
            Constants.SCREEN_WIDTH, Constants.SCREEN_HEIGHT, Constants.BLACK);

        public SceneManager()
        {
        }

        public void PrepareScene(string scene, Cast cast, Script script)
        {
            
        }

        
    }
}