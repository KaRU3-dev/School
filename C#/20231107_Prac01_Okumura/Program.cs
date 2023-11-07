using System;

namespace _20231107_Prac01_Okumura{
    public class Program{
        public static void Main(string[] args){
            // Create Shape array and initialize it
            Shape[] shapes = new Shape[3];

            // Get user input
            Console.Write("Enter the radius of the first circle: ");
            double r1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the radius of the second circle: ");
            double r2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the rectangle: ");
            double h = double.Parse(Console.ReadLine());

            shapes[0] = new Circle(r1);
            shapes[1] = new Rectangle(w, h);
            shapes[2] = new Circle(r2);

            // Calculate the area of the shapes
            double area1 = shapes[0].GetArea();
            double area2 = shapes[1].GetArea();
            double area3 = shapes[2].GetArea();

            // Display the results
            Console.WriteLine("The area of the first circle is {0}", area1);
            Console.WriteLine("The area of the rectangle is {0}", area2);
            Console.WriteLine("The area of the second circle is {0}", area3);
        }
    }
}
