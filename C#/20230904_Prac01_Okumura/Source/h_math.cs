// Using space
using System;

namespace _20230904_Prac01_Okumura
{
    public static class h_math
    {
        // Calculate circle area
        public static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Calculate square width and hight length
        public static double SquareAround(double width, double hight)
        {
            return (width + hight) * 2;
        }
    }
}
