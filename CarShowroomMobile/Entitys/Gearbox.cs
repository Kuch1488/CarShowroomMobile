using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Gearbox
    {
        public Gearbox()
        {
            Models = new HashSet<Model>();
        }

        [JsonProperty("idGearbox")]
        public int IdGearbox { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonIgnore]
        public virtual ICollection<Model> Models { get; set; }
    }
}
