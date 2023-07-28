using System;

namespace _2023_Summer
{
    public class Striker
    {
        private GameEngine gameEngine = new();

        /// <summary>
        /// void to GameEngine.Start()
        /// </summary>
        public void Ignition()
        {
            // Start
            gameEngine.Start();
            // Update loop
            gameEngine.Update();
        }
    }
}
