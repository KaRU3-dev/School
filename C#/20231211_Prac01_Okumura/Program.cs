using System;

using Main.Calculator;

namespace Main{
    public class Program{
        public static void Main(string[] args){
            // Create new instance of Calculator
            Calculate cal = new Calculate();

            // Create delegate
            Operation op = new Operation(Calculate.Add);
            Operation op2 = new Operation(Calculate.Subtract);
            Operation op3 = new Operation(Calculate.Multiply);
            Operation op4 = new Operation(Calculate.Divide);

            // Call delegate
            double reAdd = op(1, 2);
            double reSubtract = op2(1, 2);
            double reMultiply = op3(1, 2);
            double reDivide = op4(1, 2);

            // Print result
            Console.WriteLine(reAdd);
            Console.WriteLine(reSubtract);
            Console.WriteLine(reMultiply);
            Console.WriteLine(reDivide);
        }
    }
}
