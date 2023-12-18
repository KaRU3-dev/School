using System;

namespace Game.Engine.Player{
    public class PlayerGuesser{
        private int input;

        // Player guesses the number (limit 3 guesses)
        // If player guesses correctly, they win.
        public int Guess(int guessNum, int guessCount){
            Console.WriteLine("Guess the number: ");
            input = Convert.ToInt32(Console.ReadLine());
            guessCount++;
            return input;
        }
    }
}
