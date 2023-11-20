// Using space
using System;

namespace _20231113_Class{
    class Program{
        static void Main(string[] args){
            // Create animal instance
            Bird bird = new();
            bird.MakeSound();
            bird.Sleep();
            bird.Fly();

            Pig pig = new();
            pig.MakeSound();
            pig.Sleep();
            pig.Smell();
        }
    }
}
