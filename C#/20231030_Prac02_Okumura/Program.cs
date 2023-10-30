using System;

namespace _20231030_Prac02_Okumura{

    interface IRead{
        void ReadData();
    }

    interface IWrite{
        void WriteData();
    }

    class FileReader : IRead, IWrite{
        // Target file path
        private string _path = "./output.txt";
        // Object to be written to file
        private string obj;

        // Get data from user input
        public void ReadData(){
            // Input data
            Console.WriteLine("Please enter object");
            Console.Write("> ");
            obj = Console.ReadLine();
        }

        // Write data to file
        public void WriteData(){
            Console.WriteLine("[INFO] Writing data to file...");

            // Write data to file
            System.IO.File.WriteAllText(_path, obj);

            Console.WriteLine("[INFO] Data written to file.");
            Console.WriteLine("[INFO] Check file at: " + _path);
        }
    }

    internal class Program{
        public static void Main(string[] args){
            // Create new instance of FileReader
            FileReader fileReader = new FileReader();

            // Read data
            fileReader.ReadData();

            // Write data
            fileReader.WriteData();
        }
    }
}
