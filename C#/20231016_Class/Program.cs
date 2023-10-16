using System;

namespace _20231016_Class{
    public class Program{
        public static void Main(string[] args){
            // Create an instance of Class1
            Class1 class1 = new Class1();

            // Call HelloWorld() method
            class1.HelloWorld();


            // Init
            String name = "";
            // Ask for name
            Console.Write("What is your animal's name?: ");
            name = Console.ReadLine();
            // Create an instance of Dog
            Dog dog = new Dog(name);
            // Call ShowAnimalName() method
            dog.ShowAnimalName();
            // Call Bark() method
            dog.Bark();
        }
    }
}
