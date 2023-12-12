using System;

namespace GameCore.Characters{
    public interface ICharacters{
        public static int num1 { get; set; }
        public static int num2 { get; set; }

        public int Add(int num1, int num2);
        public int Subtract(int num1, int num2);
        public int Multiply(int num1, int num2);
        public int Divide(int num1, int num2);
    }
}
