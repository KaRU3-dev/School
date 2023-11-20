using System;

using _20231113_Prac02_Okumura.Game;
using _20231113_Prac02_Okumura.Abstract;

namespace _20231113_Prac02_Okumura{
    class Program{
        static void Main(string[] args){
            // Create game
            Games game = new RandomNumberGame();

            // Start game
            game.Start();
        }
    }
}
