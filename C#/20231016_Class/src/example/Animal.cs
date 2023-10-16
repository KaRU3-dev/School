using System;

namespace _20231016_Class{
    public class Animal{

        // Init
        string name;

        public Animal(string Name){
            name = Name;
        }

        public void ShowAnimalName(){
            Console.WriteLine(name);
        }
    }
}
