// using space
using System;

namespace _20230911_Alarm_Okumura.sys
{
    public static class ConsoleRequest
    {
        // Request int in console
        public static int RequestTime(string msg, string errmsg)
        {
            int result;

            System.Console.Write(msg);

            while (int.TryParse(System.Console.ReadLine(), out result) == false)
            {
                System.Console.WriteLine(errmsg);

                // Request again
                System.Console.Write(msg);
            }

            return result;
        }
        public static int RequestSecond(string msg)
        {
            int result;

            System.Console.Write(msg);

            while (int.TryParse(System.Console.ReadLine(), out result) == false)
            {
                System.Console.WriteLine("Invalid input. Please try again.");

                // Request again
                System.Console.Write(msg);
            }

            return result;
        }

        // Request int HH:MM in console
        public static int RequestClock(string msg, string msg2)
        {
            int result;

            System.Console.Write(msg);

            while (int.TryParse(System.Console.ReadLine(), out result) == false)
            {
                System.Console.WriteLine("Invalid input. Please try again.");

                // Request again
                System.Console.Write(msg);
            }

            return result;
        }
    }
}
