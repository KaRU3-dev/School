// Using space
using System;

namespace _20230904_Prac01_Okumura
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Calculate circle area
            double radius;

            Console.Write("Input radius: ");
            radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Circle area: {0}", h_math.CircleArea(radius));

            // Calculate square width and hight length
            double width, hight;

            Console.Write("Input width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Input hight: ");
            hight = double.Parse(Console.ReadLine());

            Console.WriteLine("Square around: {0}", h_math.SquareAround(width, hight));
        }
    }
}
