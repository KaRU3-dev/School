using System;

namespace _2023_Summer
{
    public class Rectangle
    {
        private double width;
        private double height;

        public void RequestAmount()
        {
            // Request width
            Console.Write($"Enter width: ");
            string input = Console.ReadLine();
            // Input check
            while(!(double.TryParse(input, out width)))
            {
                Console.Write($"[ERROR] Can't change string to double.\nEnter width: ");
                input = Console.ReadLine();
            }

            // Request height
            Console.Write($"Enter height: ");
            input = Console.ReadLine();
            // Input check
            while(!(double.TryParse(input, out height)))
            {
                Console.Write($"[ERROR] Can't change string to double.\nEnter width: ");
                input = Console.ReadLine();
            }

            // Show result
            Console.WriteLine($"-----------------------------------------\n\n RESULTS");
            Console.WriteLine($"Area: {CalculateAreaSize(width, height)} cm^2 \nPerimeter: {CalculatePerimeter(width, height)} cm\n\n");
        }

        private double CalculateAreaSize(double width, double height)
        {
            double ans = width * height;

            return ans;
        }

        private double CalculatePerimeter(double width, double height)
        {
            double perimeter = (width * 2) + (height * 2);

            return perimeter;
        }
    }
}
