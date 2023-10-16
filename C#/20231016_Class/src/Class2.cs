using System;

namespace _20231016_Class{
    public class Class2{
        // Logger
        /// <summary>
        /// Console.WriteLine() wrapper
        /// </summary>
        /// <param name="message">String</param>
        public void LogWriteLine(string message){
            Console.WriteLine(message);
        }
        /// <summary>
        /// Console.Write() wrapper
        /// </summary>
        /// <param name="message">String</param>
        public void LogWrite(string message){
            Console.Write(message);
        }
    }
}
