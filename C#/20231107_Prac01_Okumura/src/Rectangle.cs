using System;

namespace _20231107_Prac01_Okumura{
    public class Rectangle : Shape{

        private double w;
        private double h;

        public Rectangle(double w, double h){
            this.w = w;
            this.h = h;
        }

        public override double GetArea(){
            // Calculate the area of a rectangle
            return w * h;
        }
    }
}
