using Newtonsoft.Json;
using System;

namespace ThingsparkLibrary
{
    /// <summary>
    /// Class of a thingspark Entry item
    /// </summary>
    public class ThingsparkEntry
    {
        [JsonProperty(PropertyName = "channel_id")]
        public int ChannelId { get; set; }

        [JsonProperty(PropertyName = "field1")]
        public string Field1 { get; set; }

        [JsonProperty(PropertyName = "field2")]
        public string Field2 { get; set; }

        [JsonProperty(PropertyName = "field3")]
        public string Field3 { get; set; }

        [JsonProperty(PropertyName = "field4")]
        public string Field4 { get; set; }

        [JsonProperty(PropertyName = "field5")]
        public string Field5 { get; set; }

        [JsonProperty(PropertyName = "field6")]
        public string Field6 { get; set; }

        [JsonProperty(PropertyName = "field7")]
        public string Field7 { get; set; }

        [JsonProperty(PropertyName = "field8")]
        public string Field8 { get; set; }
        
        [JsonProperty(PropertyName = "field9")]
        public string Field9 { get; set; }

        [JsonProperty(PropertyName = "field10")]
        public string Field10 { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

    }
}
