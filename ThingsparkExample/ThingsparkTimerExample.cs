using System;
using System.Timers;
using Thingspark.Client;

namespace ThingsparkExample
{
    class ThingsparkTimerExample
    {

        private static Timer aTimer;

        static void Main2(string[] args)
        {
            aTimer = new System.Timers.Timer(30000);
            aTimer.Elapsed += OnTimedEvent;

            aTimer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program... ");
            Console.ReadLine();
            Console.WriteLine("Terminating the application...");
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);

            var client = new ThingsparkClient("XDFfQDZORdmHzFgx");

            Random rand = new Random();
            int a = rand.Next(1, 10);
            int b = rand.Next(100, 200);

            var v = client.SendDataToThingspark(out int r,  Convert.ToString(a), Convert.ToString(b));
            Console.WriteLine(v);
            Console.WriteLine(r);
        }

    }
}
