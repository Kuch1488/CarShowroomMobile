using Newtonsoft.Json;
using System;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Body
    {
        [JsonProperty("idBody")]
        public int idBody { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
        [JsonProperty("door")]
        public int Door { get; set; }
    }
}
