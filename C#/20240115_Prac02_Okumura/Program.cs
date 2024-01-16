using System;

namespace Source {
    public class Program {
        public static void Main(string[] args) {

            // Create RandomGen object
            Sys.RandomGen randomGen = new Sys.RandomGen();

            // Generate random numbers
            randomGen.Generate(0, 100, 30);

            // Get random numbers
            int[] rndInts = randomGen.GetRndInts();

            // Get numbers from array onl can divide by 2 using LINQ
            var evenNumbers = rndInts.Where(x => x % 2 == 0);

            // Calculate average of even numbers
            double average = evenNumbers.Average();

            // Print average
            Console.WriteLine(average);
        }
    }
}
