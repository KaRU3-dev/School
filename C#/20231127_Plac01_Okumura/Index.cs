using System;

// namespace
using Game;
using Game.Characters;

namespace _20231127_Plac01_Okumura{

    /// <summary>
    /// Simple Baseball game
    /// 18 rounds
    /// 3strike change batter, 3 out change team
    /// </summary>
    public class Index{
        public static void Main(String[] args){
            // Create new game
            GameCore game = new();

            // Start the game
            game.Start();

            // Game loop
            game.Update();
        }
    }
}
