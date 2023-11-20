using System;

using _20231113_Prac01_Okumura.Abstract.Shape;

namespace _20231113_Prac01_Okumura{
    public class Circle : Shapes{

        public double Radius { get; set; }

        public override double CalculateArea(){
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
