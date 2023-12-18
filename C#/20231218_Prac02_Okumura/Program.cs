using System;
using Game.Main;

namespace _20231218_Prac02_Okumura{
    public class Program{
        public static void Main(string[] args){
            // Create a new instance of GameCore
            GameCore game = new();

            // Initialize the guess number
            game.InitializeGuessNum();

            // Start the game
            game.Guess(game.GuessNum);
        }
    }
}
