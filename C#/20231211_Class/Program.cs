using System;

namespace _20231211_Class
{
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            MyDelegate Callback;

            Callback = new MyDelegate(Calculator.Plus);
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Callback(7, 5));
        }
    }
}
