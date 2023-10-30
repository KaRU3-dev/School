using System;

namespace _20231030_Prac03_Okumura{
    public class Photo : IPrintable{
        /// <summary>
        /// Photo.Print() prints a message to the console.
        /// </summary>
        public void Print(){
            Console.WriteLine("Photo.Print() called.");
        }
    }
}
