using System;

namespace _20231030_Prac03_Okumura{
    internal class Program{
        public static void Main(string[] args){
            // Init
            Document document = new Document();
            Photo photo = new Photo();

            // Print
            document.Print();
            photo.Print();
        }
    }
}
