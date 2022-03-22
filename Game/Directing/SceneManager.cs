using System;
using System.Collections.Generic;
using System.IO;
using Unit06.Game.Casting;
using Unit06.Game.Scripting;
using Unit06.Game.Services;


namespace Unit06.Game.Directing
{
    public class SceneManager
    {
        public static AudioService AudioService = new RaylibAudioService();
        public static KeyboardService KeyboardService = new RaylibKeyboardService();
        public static MouseService MouseService = new RaylibMouseService();
        public static PhysicsService PhysicsService = new RaylibPhysicsService();
        public static VideoService VideoService = new RaylibVideoService(Constants.GAME_NAME,
            Constants.SCREEN_WIDTH, Constants.SCREEN_HEIGHT, Constants.BLACK);



        public SceneManager()
        {
        }

        public void PrepareScene(string scene, Cast cast, Script script)
        {
            if (scene == Constants.NEW_GAME)
            {
                PrepareNewGame(cast, script);
            }
            else if (scene == Constants.NEXT_LEVEL)
            {
                PrepareNextLevel(cast, script);
            }
            else if (scene == Constants.TRY_AGAIN)
            {
                PrepareTryAgain(cast, script);
            }
            else if (scene == Constants.IN_PLAY)
            {
                PrepareInPlay(cast, script);
            }
            else if (scene == Constants.GAME_OVER)
            {
                PrepareGameOver(cast, script);
            }
        }

        private void PrepareNewGame(Cast cast, Script script)
        {
            
            AddTurret(cast);
            AddTower(cast);
            AddWallTop(cast);
            AddWallBottom(cast);
            AddEnemy(cast);
         

            script.ClearAllActions();
            AddInitActions(script);
            AddLoadActions(script);

            ChangeSceneAction a = new ChangeSceneAction(KeyboardService, Constants.NEXT_LEVEL);
            script.AddAction(Constants.INPUT, a);

            AddOutputActions(script);
            AddUnloadActions(script);
            AddReleaseActions(script);
        }

      

        private void PrepareNextLevel(Cast cast, Script script)
        {
            
            
            AddDialog(cast, Constants.PREP_TO_LAUNCH);

            script.ClearAllActions();

            TimedChangeSceneAction ta = new TimedChangeSceneAction(Constants.IN_PLAY, 2, DateTime.Now);
            script.AddAction(Constants.INPUT, ta);

            AddOutputActions(script);

            PlaySoundAction sa = new PlaySoundAction(AudioService, Constants.WELCOME_SOUND);
            script.AddAction(Constants.OUTPUT, sa);
        }

        private void PrepareTryAgain(Cast cast, Script script)
        {
            
            
            AddDialog(cast, Constants.PREP_TO_LAUNCH);

            script.ClearAllActions();
            
            TimedChangeSceneAction ta = new TimedChangeSceneAction(Constants.IN_PLAY, 2, DateTime.Now);
            script.AddAction(Constants.INPUT, ta);
      
            AddOutputActions(script);
        }

        private void PrepareInPlay(Cast cast, Script script)
        {
            // ActivateBall(cast);
            cast.ClearActors(Constants.DIALOG_GROUP);

            script.ClearAllActions();



           
            AddOutputActions(script);
        
        }

        private void PrepareGameOver(Cast cast, Script script)
        {
           
           
            AddDialog(cast, Constants.WAS_GOOD_GAME);

            script.ClearAllActions();

            TimedChangeSceneAction ta = new TimedChangeSceneAction(Constants.NEW_GAME, 5, DateTime.Now);
            script.AddAction(Constants.INPUT, ta);

            AddOutputActions(script);
        }

        // -----------------------------------------------------------------------------------------
        // casting methods
        // -----------------------------------------------------------------------------------------

        private void AddTurret(Cast cast)
        {
            cast.ClearActors(Constants.TURRET_GROUP);
        
            int x = Constants.SCREEN_WIDTH - Constants.TOWER_WIDTH - Constants.TURRET_WIDTH;
            int y = Constants.WALL_HEIGHT + Constants.TURRET_HEIGHT - 25;
        
            Point position = new Point(x, y);
            Point size = new Point(Constants.TURRET_WIDTH, Constants.TURRET_HEIGHT);
            Point velocity = new Point(0, 0);
        
            Body body = new Body(position, size, velocity);
            Image image = new Image(Constants.TURRET_IMAGE);
            Turret ball = new Turret(body, image, false);
        
            cast.AddActor(Constants.TURRET_GROUP, ball);
        }

        private void AddTower(Cast cast)
        {
            cast.ClearActors(Constants.TOWER_GROUP);

            int x = 800;
            int y = 150;

            Point position = new Point(x, y);
            Point size = new Point(Constants.TOWER_WIDTH, Constants.TOWER_HEIGHT);
            Point velocity = new Point(0, 0);

            Body body = new Body(position, size, velocity);
            Image image = new Image(Constants.TOWER_IMAGE);
            Tower tower = new Tower(body, image, false);

            cast.AddActor(Constants.TOWER_GROUP, tower);
        }

        private void AddWallTop(Cast cast)
        {
        

            int x = 0;
            int y = 0;

            Point position = new Point(x, y);
            Point size = new Point(Constants.WALL_WIDTH, Constants.WALL_HEIGHT);
            Point velocity = new Point(0, 0);

            Body body = new Body(position, size, velocity);
            Image image = new Image(Constants.WALL_IMAGE);
            Wall wallTop = new Wall(body, image, false);

            cast.AddActor(Constants.WALL_GROUP, wallTop);
        }

        private void AddWallBottom(Cast cast)
        {

            int x = 0;
            int y = 550;

            Point position = new Point(x, y);
            Point size = new Point(Constants.WALL_WIDTH, Constants.WALL_HEIGHT);
            Point velocity = new Point(0, 0);

            Body body = new Body(position, size, velocity);
            Image image = new Image(Constants.WALL_IMAGE);
            Wall wallBottom = new Wall(body, image, false);

            cast.AddActor(Constants.WALL_GROUP, wallBottom);
        }

        private void AddEnemy(Cast cast)
        {   
            int x = 100;
            int y = 300;

            Point position = new Point(x, y);
            Point size = new Point(Constants.ENEMY_WIDTH, Constants.ENEMY_HEIGHT);
            Point velocity = new Point(0, 0);

            Body body = new Body(position, size, velocity);
            Image image = new Image(Constants.ENEMY_IMAGE);
            Enemy enemy = new Enemy(body, image, false);

            cast.AddActor(Constants.ENEMY_GROUP, enemy);
        }



       

        private void AddDialog(Cast cast, string message)
        {
            cast.ClearActors(Constants.DIALOG_GROUP);

            Text text = new Text(message, Constants.FONT_FILE, Constants.FONT_SIZE, 
                Constants.ALIGN_CENTER, Constants.WHITE);
            Point position = new Point(Constants.CENTER_X, Constants.CENTER_Y);

            Label label = new Label(text, position);
            cast.AddActor(Constants.DIALOG_GROUP, label);   
        }

        private void AddLevel(Cast cast)
        {
            cast.ClearActors(Constants.LEVEL_GROUP);

            Text text = new Text(Constants.LEVEL_FORMAT, Constants.FONT_FILE, Constants.FONT_SIZE, 
                Constants.ALIGN_LEFT, Constants.WHITE);
            Point position = new Point(Constants.HUD_MARGIN, Constants.HUD_MARGIN);

            Label label = new Label(text, position);
            cast.AddActor(Constants.LEVEL_GROUP, label);
        }

        private void AddLives(Cast cast)
        {
            cast.ClearActors(Constants.LIVES_GROUP);

            Text text = new Text(Constants.LIVES_FORMAT, Constants.FONT_FILE, Constants.FONT_SIZE, 
                Constants.ALIGN_RIGHT, Constants.WHITE);
            Point position = new Point(Constants.SCREEN_WIDTH - Constants.HUD_MARGIN, 
                Constants.HUD_MARGIN);

            Label label = new Label(text, position);
            cast.AddActor(Constants.LIVES_GROUP, label);   
        }

  

        private void AddScore(Cast cast)
        {
            cast.ClearActors(Constants.SCORE_GROUP);

            Text text = new Text(Constants.SCORE_FORMAT, Constants.FONT_FILE, Constants.FONT_SIZE, 
                Constants.ALIGN_CENTER, Constants.WHITE);
            Point position = new Point(Constants.CENTER_X, Constants.HUD_MARGIN);
            
            Label label = new Label(text, position);
            cast.AddActor(Constants.SCORE_GROUP, label);   
        }

        private void AddStats(Cast cast)
        {
            cast.ClearActors(Constants.STATS_GROUP);
            Stats stats = new Stats();
            cast.AddActor(Constants.STATS_GROUP, stats);
        }

        private List<List<string>> LoadLevel(string filename)
        {
            List<List<string>> data = new List<List<string>>();
            using(StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();
                    List<string> columns = new List<string>(row.Split(',', StringSplitOptions.TrimEntries));
                    data.Add(columns);
                }
            }
            return data;
        }

        // -----------------------------------------------------------------------------------------
        // scriptig methods
        // -----------------------------------------------------------------------------------------

        private void AddInitActions(Script script)
        {
            script.AddAction(Constants.INITIALIZE, new InitializeDevicesAction(AudioService, 
                VideoService));
        }

        private void AddLoadActions(Script script)
        {
            script.AddAction(Constants.LOAD, new LoadAssetsAction(AudioService, VideoService));
        }

        private void AddOutputActions(Script script)
        {
            script.AddAction(Constants.OUTPUT, new StartDrawingAction(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawHudAction(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawTurret(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawTower(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawWall(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawWall(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawWEnemy(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawDialogAction(VideoService));
            script.AddAction(Constants.OUTPUT, new EndDrawingAction(VideoService));
        }

        private void AddUnloadActions(Script script)
        {
            script.AddAction(Constants.UNLOAD, new UnloadAssetsAction(AudioService, VideoService));
        }

        private void AddReleaseActions(Script script)
        {
            script.AddAction(Constants.RELEASE, new ReleaseDevicesAction(AudioService, 
                VideoService));
        }

 
    }
}