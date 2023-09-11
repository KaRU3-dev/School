// Using space
using System;

namespace _20230911_Alarm_Okumura
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // timer
            Timer timer = new Timer();
            timer.RequestTime();
            timer.Countdown(timer.Minutes);

            // alarm
            Alarm alarm = new Alarm();
            alarm.RequestTime();
            alarm.AlarmSound(alarm.Clock);
        }
    }
}
