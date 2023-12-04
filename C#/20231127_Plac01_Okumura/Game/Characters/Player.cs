using System;

using Game.Characters.Interface;

namespace Game.Characters{
    public class Player : ICharacter{
        public int score { get; set; }

        public int NumSelect(){
            // Input num
            int num = 0;

            // Request input from the user
            Console.Write("Please enter a number: ");
            // Try to convert the input to an integer, while tryparse is true, continue to ask for input
            while(!int.TryParse(Console.ReadLine(), out num) && num < 0 && num > 3){
                Console.Write("Please enter a number: ");
            }

            // Print the number
            Console.WriteLine("You entered: " + num);

            return num;
        }
    }
}
