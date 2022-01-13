using Newtonsoft.Json;
using System;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Option
    {
        [JsonProperty("idOption")]
        public int IdOption { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
