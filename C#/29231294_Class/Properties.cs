using System;

namespace _29231204_Class
{
    struct Rectangle
    {
        private int width;
        private int height;

        public int Width
        {
            get{return width;}
            set{width = value;}
        }

        public int Height
        {
            get{return height;}
            set{height = value;}
        }

        public int Area
        {
            get{return width * height;}
        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }

    public class Properties
    {
        public static void RectangleTest()
        {
            Rectangle rect = new Rectangle(10, 20);
            Console.WriteLine($"Area = {rect.Area}");
            rect.Width = 30;
            rect.Height = 40;
            Console.WriteLine($"Area = {rect.Area}");
        }
    }
}
