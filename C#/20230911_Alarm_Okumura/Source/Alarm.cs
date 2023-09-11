// Using space
using System;
using _20230911_Alarm_Okumura.Sys;

namespace _20230911_Alarm_Okumura
{
    public class Alarm
    {
        public int Clock { get; set; }

        // Request
        public void RequestTime()
        {

            int result;

            result = sys.ConsoleRequest.RequestClock(SystemLog.RequestClock, SystemLog.InvalidInput);

            // Set
            this.Clock = result;
        }

        // Alarm sound when clock is same as current time
        public void AlarmSound(int clock)
        {
            // Alarmed?
            bool alarmed = true;

            while (alarmed)
            {
                // Get current time
                DateTime now = DateTime.Now;

                // Set hour and time
                int hour = now.Hour;
                int min = now.Minute;

                // Compare hour and time
                if ((hour == clock / 100) && (min == clock % 100))
                {
                    // Alarm sound
                    Console.Beep(1000, 1000);

                    // Alarmed
                    alarmed = false;
                }
            }
        }
    }
}
