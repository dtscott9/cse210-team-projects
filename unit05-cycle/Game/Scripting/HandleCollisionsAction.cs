using System;
using System.Collections.Generic;
using System.Data;
using unit05_cycle.Game.Casting;
using unit05_cycle.Game.Services;


namespace unit05_cycle.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the snake 
    /// collides with the food, or the snake collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool player1Win = false;
        private bool player2Win = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (player1Win == false && player2Win == false)
            {
                HandleFoodCollisions(cast);
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
            }
        }

        /// <summary>
        /// Updates the score nd moves the food if the snake collides with it.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleFoodCollisions(Cast cast)
        {
            Cycle cycle = (Cycle)cast.GetFirstActor("Cycle");
            Score score = (Score)cast.GetFirstActor("score");
            
     
        }

        /// <summary>
        /// Sets the game over flag if the snake collides with one of its segments.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
            Cycle cycle = (Cycle)cast.GetFirstActor("Cycle");
            cycle.GrowTail(1, Constants.GREEN);
            Cycle cycle1 = (Cycle)cast.GetFirstActor("Cycle1");
            cycle1.GrowTail(1, Constants.RED);
            Actor head = cycle.GetHead();
            List<Actor> body = cycle.GetBody();
            
            Actor head1 = cycle1.GetHead();
            List<Actor> body1 = cycle1.GetBody();
            

            foreach (Actor segment in body)
            {
                if (segment.GetPosition().Equals(head1.GetPosition()))
                {
                    player1Win = true;
                }
            }
             foreach (Actor segment in body)
            {
                if (segment.GetPosition().Equals(head.GetPosition()))
                {
                    player2Win = true;
                }
            }

            foreach (Actor segment1 in body1)
            {
                if (segment1.GetPosition().Equals(head.GetPosition()))
                {
                    player2Win = true;
                }
            }

             foreach (Actor segment1 in body1)
            {
                if (segment1.GetPosition().Equals(head1.GetPosition()))
                {
                    player1Win = true;
                }
            }
        }

        private void HandleGameOver(Cast cast)
        {
            if (player2Win == true)
            {
                Cycle cycle = (Cycle)cast.GetFirstActor("Cycle");
                List<Actor> segments = cycle.GetSegments();
            
                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);
                
                Actor message = new Actor();
                message.SetText("Player 2 Wins!");
                message.SetPosition(position);
                cast.AddActor("messages", message);
                

                // make everything white
                foreach (Actor segment in segments)
                {
                    segment.SetColor(Constants.WHITE);
                
                }
                
            }

            else if (player1Win == true)
            {
                Cycle cycle1 = (Cycle)cast.GetFirstActor("Cycle1");
                List<Actor> segments1 = cycle1.GetSegments();
            
                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Player 1 Wins!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                // make everything white
                foreach (Actor segment1 in segments1)
                {
                    segment1.SetColor(Constants.WHITE);
                }
                
            }
        }

    }
}