using System;

namespace _20231204_Prac02_Okumura
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Rectangleをインスタンス化
            Rectangle rect = new(10, 20);

            // 面積を取得
            double area = rect.GetArea();
            Console.WriteLine($"面積: {area}");

            // Circleをインスタンス化
            Circle circle = new(10);

            // 面積を取得
            area = circle.GetArea();
            Console.WriteLine($"面積: {area}");
        }
    }
}
