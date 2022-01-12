using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Body
    {
        public Body()
        {
            Models = new HashSet<Model>();
        }

        [JsonProperty("idBody")]
        public int idBody { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
        [JsonProperty("door")]
        public int Door { get; set; }

        [JsonIgnore]
        public virtual ICollection<Model> Models { get; set; }
    }
}
