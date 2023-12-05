using System;
using System.Security.Cryptography;

namespace _20231205_Class
{
    public record Point2D(int X, int Y)
    {
        public int Property { get; }

        public Point2D(int x, int y, int property) : this(x, y) => Property = property;

        public void Get()
        {
            Console.WriteLine($"X: {X}, Y: {Y}, Property: {Property}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // インスタンス化
            Point2D p = new Point2D(10, 20, 30);

            // 判定
            Console.WriteLine(p.Equals(p)); // True

            // ハッシュ値
            Console.WriteLine(p.GetHashCode()); // 10, 20のハッシュ値

            // Point2Dのプロパティを取得する
            p.Get();
        }
    }
}
