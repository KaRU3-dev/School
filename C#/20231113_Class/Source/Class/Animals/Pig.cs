using System;

namespace _20231113_Class{
    public class Pig : Animal{
        public override void MakeSound(){
            Console.WriteLine("Booo");
        }

        public void Smell(){
            Console.WriteLine("Fuga Fuga");
        }
    }
}
