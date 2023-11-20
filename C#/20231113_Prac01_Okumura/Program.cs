using System;

using _20231113_Prac01_Okumura.Abstract;

namespace _20231113_Prac01_Okumura{
    class Program{
        static void Main(string[] args){

            // Create a new instance of Circle
            Circle circle = new Circle();
            circle.Radius = 5;
            Console.WriteLine("Circle Area: " + circle.CalculateArea());

            // Create a new instance of Rectangle
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
        }
    }
}
