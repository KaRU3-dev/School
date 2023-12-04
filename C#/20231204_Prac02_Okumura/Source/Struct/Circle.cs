using System;

namespace _20231204_Prac02_Okumura
{
    public struct Circle : ICircle
    {
        public double Radius {get; set;}

        public double r
        {
            get { return this.Radius; }
            set { this.Radius = value; }
        }

        public Circle(double r)
        {
            this.Radius = r;
        }

        public double GetArea()
        {
            return this.Radius * this.r * Math.PI;
        }
    }
}
