using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace ThingsparkLibrary
{
    /// <summary>
    /// Class of a thingspark Data item which you get back when you ask for all entries in a channel
    /// </summary>
    public class ThingsparkData
    {
        [JsonProperty(PropertyName = "channel")]
        public ThingsparkChannel Channel { get; set; }

        [JsonProperty(PropertyName = "entrys")]
        public Collection<ThingsparkEntry> Entrys{ get; set; }
    }
}
