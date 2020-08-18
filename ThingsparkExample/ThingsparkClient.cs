using System;
using System.Net;
using System.Text;

namespace Thingspark.Client
{
    public class ThingsparkClient
    {
        private string ApiKey { get; }
        private const string Url = "https://api.thingspark.kr/";

        public ThingsparkClient(string apiKey)
        {
            ApiKey = apiKey;
        }

        public Boolean SendDataToThingspark(out Int32 r_value, params string[] fields)
        {
            var sbQs = new StringBuilder();

            // Build the querystring
            sbQs.Append(Url + "channels/entrys?apiKey=" + ApiKey);
            for (var x = 0; x < fields.Length; x++)
            {
                var index = x + 1;
                if (!string.IsNullOrEmpty(fields[x])) sbQs.Append("&field" + index + "=" + Uri.EscapeDataString(fields[x]));
            }

            // The response will be a "0" if there is an error or the entry_id if > 0
            r_value = Convert.ToInt32(PostToThingspark(sbQs.ToString()));

            return (r_value > 0);

        }

        private string PostToThingspark(string queryString)
        {
            var wc = new WebClient();
            return wc.DownloadString(queryString);
        }
    }
}
