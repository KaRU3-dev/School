using System;

using Game.Characters.Interface;

namespace Game.Characters{
    public class Computer : ICharacter{

        public int score {get; set;}

        public int NumSelect(){
            // Input num
            int num = 0;

            // Generate a random number between 0 and 3
            Random rnd = new();
            num = rnd.Next(0, 3);

            // Print the number
            Console.WriteLine("Computer entered: " + num);

            return num;
        }
    }
}
