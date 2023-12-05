// .NET Framework: 8.0
using System;

// 名前空間
using App.Record;

namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // インスタンス化
            Blog blog1 = new Blog("タイトル", "本文");
            Blog blog2 = new Blog("タイトル", "本文");

            // 判定
            Console.WriteLine(blog1.Equals(blog2)); // True
            Console.WriteLine(blog2.Equals(blog1)); // True
        }
    }
}
