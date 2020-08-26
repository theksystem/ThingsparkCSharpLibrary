using System;
using System.Net.Http;
using System.Threading.Tasks;
using Thingspark.Client;

namespace ThingsparkExample
{
    class ThingsparkExample
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string API_KEY = "<API KEY>";
        static async Task Main(string[] args)
        {
            // 예제 1 실행
            //example1();

            // 예제 2 실행
            await example2();
        }

        static void example1()
        {            
            var thingsparkClient = new ThingsparkClient(API_KEY);

            var v = thingsparkClient.SendDataToThingspark(out int r, "1", "2");
            Console.WriteLine(v);
            Console.WriteLine(r);
        }

        private static async Task example2()
        {            
            Random rand = new Random();
            int v1 = rand.Next(1, 100);
            int v2 = rand.Next(100, 200);

            string url = "https://api.thingspark.kr/channels/entrys?apiKey="+ API_KEY + "&field1="+v1+"&field2="+v2;
            var s = client.GetStringAsync(url);
            var msg = await s;
            Console.WriteLine(msg);
        }
    }
}
