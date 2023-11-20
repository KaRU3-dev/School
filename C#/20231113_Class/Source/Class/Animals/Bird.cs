using System;

namespace _20231113_Class{
    public class Bird : Animal{
        public override void MakeSound(){
            Console.WriteLine("Gaaaaaa");
        }

        public void Fly(){
            Console.WriteLine("I can't fly...");
        }
    }
}
