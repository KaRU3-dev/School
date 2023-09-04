// Using space
using System;

namespace _20230904_Prac02_Okumura
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Student profile
            string std1_name = "chiba";
            int std1_score = 80;

            string std2_name = "okumura";
            int std2_score = 60;


            // Average score
            // Add the scores
            int all_score = h_math.Add(std1_score, std2_score);
            // Divide the scores
            int avg_score = h_math.Avg(all_score, 2);

            // Output
            Console.WriteLine("Average score: " + avg_score);
        }
    }
}
