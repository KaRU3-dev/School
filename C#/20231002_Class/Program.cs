using System;

namespace _20231002_Class
{
    public class Person{

        private string _name;
        private int _age;

        public string Name{
            get { return _name; }
            set {
                if (!string.IsNullOrEmpty(value)){
                    _name = value;
                }
                else {
                    throw new ArgumentException("Name cannot be null or empty");
                }
            }
        }

        public int Age {
            get { return _age; }
            set {
                if (value >= 0 && value <= 120){
                    _age = value;
                }
                else {
                    throw new ArgumentException("Age is invalid number");
                }
            }
        }

        // Constructor
        public Person(string name, int age){
            Name = name;
            Age = age;
        }

        // Method
        public void DisplayInfo(){
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    internal class Program
    {
        public static void Main()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Person person = new Person(name, age);

            person.DisplayInfo();
        }
    }
}
