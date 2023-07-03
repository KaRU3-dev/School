using System;

namespace _20230703_Class3.src{
    public class UsingThisMethod{
        private string Name;

        public void DisplayInfo(string name){
            Name = name;
            Console.WriteLine($"Name: {name}");
            Introduce(Name);
        }

        public void Introduce(string name){
            Console.WriteLine($"Hi, My name is {name}");
        }
    }
}