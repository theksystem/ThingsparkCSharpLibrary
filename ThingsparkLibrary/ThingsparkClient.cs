using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ThingsparkLibrary
{
    public class ThingsparkClient
    {
        #region Fields

        private static string _thingsparkHost;
        private string _requestUri;

        // max values
        private const int thingsparkMaxStatus = 140;

        #endregion

        public ThingsparkClient(bool sslRequired)
        {
            _thingsparkHost = sslRequired ? "https://api.thingspark.kr" : "http://api.thingspark.kr";
        }

        public async Task<object> UpdateEntryAsync(string apiKey, ThingsparkEntry entry)
        {
            // check for API Key
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentNullException("APIKEY", "You must specify a API Key");
            }

            // check at leaset one field value not empty
            if (String.IsNullOrEmpty(entry.Field1) && String.IsNullOrEmpty(entry.Field2) &&
                String.IsNullOrEmpty(entry.Field3) && String.IsNullOrEmpty(entry.Field4) &&
                String.IsNullOrEmpty(entry.Field5) && String.IsNullOrEmpty(entry.Field6) &&
                String.IsNullOrEmpty(entry.Field7) && String.IsNullOrEmpty(entry.Field8))
            {
                throw new ArgumentNullException("entry", "You must specify one field at least");
            }

            // build body
            var body = String.Empty;
            // fields
            if (!String.IsNullOrEmpty(entry.Field1))
            {
                body += "field1=" + entry.Field1 + "&";
            }
            if (!String.IsNullOrEmpty(entry.Field2))
            {
                body += "field2=" + entry.Field2 + "&";
            }
            if (!String.IsNullOrEmpty(entry.Field3))
            {
                body += "field3=" + entry.Field3 + "&";
            }
            if (!String.IsNullOrEmpty(entry.Field4))
            {
                body += "field4=" + entry.Field4 + "&";
            }
            if (!String.IsNullOrEmpty(entry.Field5))
            {
                body += "field5=" + entry.Field5 + "&";
            }
            if (!String.IsNullOrEmpty(entry.Field6))
            {
                body += "field6=" + entry.Field6 + "&";
            }
            if (!String.IsNullOrEmpty(entry.Field7))
            {
                body += "field7=" + entry.Field7 + "&";
            }
            if (!String.IsNullOrEmpty(entry.Field8))
            {
                body += "field8=" + entry.Field8 + "&";
            }
            if (!String.IsNullOrEmpty(entry.Field9))
            {
                body += "field9=" + entry.Field9 + "&";
            }
            if (!String.IsNullOrEmpty(entry.Field10))
            {
                body += "field10=" + entry.Field10 + "&";
            }

            _requestUri = _thingsparkHost + "/channels/entrys";

            // build HTTP request
            string request = "apiKey=" + apiKey + "&";
            request += body;

            using (var httpClient = new HttpClient())
            {
                var stringContent = new StringContent(request, Encoding.UTF8, "application/x-www-form-urlencoded");
                var httpResponse = await httpClient.PostAsync(new Uri(_requestUri), stringContent);

                if (httpResponse.StatusCode == HttpStatusCode.OK)
                {

                    /*entry.EntryId =
                        Convert.ToInt32(
                            JsonConvert.DeserializeObject<ThingsparkEntry>(await httpResponse.Content.ReadAsStringAsync()).EntryId);*/

                    var responseContent = await httpResponse.Content.ReadAsStringAsync();
                    return responseContent;
                }

                return -1;
            }

        }

    }

}