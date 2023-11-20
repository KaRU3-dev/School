using System;

using _20231113_Prac01_Okumura.Abstract.Shape;

namespace _20231113_Prac01_Okumura{
    public class Rectangle : Shapes{

        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea(){
            return Width * Height;
        }
    }
}
