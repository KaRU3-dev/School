using System;

namespace _20231107_Prac01_Okumura{
    public class Circle : Shape{

        private double radius;

        public Circle(double r){
            radius = r;
        }

        public override double GetArea(){
            // Calculate the area of a circle
            return (int)(radius * radius * Math.PI);
        }
    }
}
