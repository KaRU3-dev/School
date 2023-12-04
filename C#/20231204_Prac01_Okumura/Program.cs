using System;

namespace _20231204_Prac01_Okumura
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of EvenNumber
            EvenNumber evenNumber = new(10);

            // Print the value of the instance
            Console.WriteLine(evenNumber.GetNum());
        }
    }
}
