using System;
using Thingspark.Client;

namespace ThingsparkExample
{
    class ThingsparkExample
    {
        static void Main(string[] args)
        {
            var client = new ThingsparkClient("hKqQALm22Hd79N6I");

            var v = client.SendDataToThingspark(out int r, "1", "2");
            Console.WriteLine(v);
            Console.WriteLine(r);
        }
    }
}
