using System;

namespace _29231204_Class
{
    public class Program
    {
        // 構造体
        struct MyPoint
        {
            public float x;
            public float y;

            public MyPoint(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public static void Main(string[] args)
        {

            // 構造体のインスタンス化
            MyPoint point = new MyPoint(1.234f, 2.3456f);

            // 構造体のメンバ変数へのアクセス
            Console.WriteLine($"x = {point.x}, y = {point.y}");

            // 構造体のメンバ変数の書き換え
            point.x = 3.456f;
            point.y = 4.5678f;

            // 構造体のメンバ変数へのアクセス
            Console.WriteLine($"x = {point.x}, y = {point.y}");

            // プロパティのテスト
            Properties.RectangleTest();
        }
    }
}
