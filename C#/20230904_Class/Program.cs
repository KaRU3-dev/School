// Using space
using System;

namespace _20230904_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer initialization
            int num1;
            int num2;

            // Integer input
            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            // Void static method
            int sum = st_helper.Add(num1, num2);
            int product = st_helper.Multiply(num1, num2);

            // Output
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
        }
    }
}
