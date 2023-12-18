using System;
using Game.Engine.Gen;
using Game.Engine.Core;
using Game.Engine.Player;

namespace Game.Main{
    public class GameCore{

        private bool GameEnd = false;

        public int GuessNum;
        private int GuessNumMin = 1;
        private int GuessNumMax = 10;
        private int GuessCount = 0;
        private int GuessLimit = 3;

        private RandomNum rndNum = new();
        private Comparisons compare = new();
        private PlayerGuesser player = new();

        public void InitializeGuessNum()
        {
            GuessNum = rndNum.Generate(GuessNumMin, GuessNumMax);
        }

        public void Guess(int guessNum){
            for (int i = 0; i < GuessLimit; i++)
            {
                if (GameEnd) {
                    break;
                }

                int input = player.Guess(GuessNum, GuessCount);
                int cmpr = compare._2int(input, GuessNum);

                if (cmpr == 0) {
                    Console.WriteLine("You guessed correctly!");
                    GameEnd = true;
                    break;
                } else if (cmpr == GuessNum) {
                    Console.WriteLine("You guessed too low!");
                } else if (cmpr == input) {
                    Console.WriteLine("You guessed too high!");
                } else {
                    Console.WriteLine("You guessed incorrectly!");
                }
            }

            if (!GameEnd) {
                Console.WriteLine($"You lose! The number was {GuessNum}.");
            }
        }

            // Player guesses the number (limit 3 guesses)
            // If player guesses correctly, they win.
    }
}
