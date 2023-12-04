using System;

namespace _20231204_Prac02_Okumura
{
    public struct Rectangle : IRectangle
    {
        public double height;
        public double width;

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="width">幅 </param>
        /// <param name="height">高さ</param>
        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;
        }

        public double GetArea()
        {
            return this.Width * this.Height;
        }
    }
}