using System;
using Newtonsoft.Json;

namespace ThingsparkLibrary
{
    /// <summary>
    /// Class of a thingspark Channel 
    /// </summary>
    public class ThingsparkChannel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

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

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

    }
}
