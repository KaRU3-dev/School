using System;

namespace _20231030_Prac03_Okumura{
    public class Document : IPrintable{
        /// <summary>
        /// Document.Print() prints a message to the console.
        /// </summary>
        public void Print(){
            Console.WriteLine("Document.Print() called.");
        }
    }
}
