using System;
using unit06_game.Game.Directing;
using unit06_game.Game.Services;

namespace Unit06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director(SceneManager.VideoService);
            director.StartGame();
        }
    }
}
