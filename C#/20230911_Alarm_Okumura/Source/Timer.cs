// Using space
using System;
using _20230911_Alarm_Okumura.Sys;

namespace _20230911_Alarm_Okumura
{
    public class Timer
    {
        public int Minutes { get; set; }

        // Request
        public void RequestTime()
        {
            int result;

            result = sys.ConsoleRequest.RequestTime(SystemLog.RequestTime, SystemLog.InvalidInput);

            // Set
            this.Minutes = result;
        }

        // Timer countdown and alarm sound
        public void Countdown(int min)
        {
            int second = min * 60;

            // Countdown
            for (int j = second; j >= 0; j--)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("{0}", j);
            }

            // Alarm sound
            Console.Beep(1000, 1000);
        }
    }
}
