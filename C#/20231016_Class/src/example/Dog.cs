using System;

namespace _20231016_Class{
    public class Dog : Animal{
        public Dog(string Name) : base(Name){}

        public void Bark(){
            Console.WriteLine("Woof!");
        }
    }
}
