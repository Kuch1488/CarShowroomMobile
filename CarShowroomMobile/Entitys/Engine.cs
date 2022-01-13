using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Engine
    {
        public Engine()
        {
            Models = new HashSet<Model>();
        }

        [JsonProperty("idEngine")]
        public int IdEngine { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
        [JsonProperty("hp")]
        public int HP { get; set; }
        [JsonProperty("consumption")]
        public int Consumption { get; set; }

        [JsonIgnore]
        public virtual ICollection<Model> Models { get; set; }
    }
}
