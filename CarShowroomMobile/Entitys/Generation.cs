using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Generation
    {
        public Generation()
        {
            Models = new HashSet<Model>();
        }

        [JsonProperty("idGeneration")]
        public int IdGeneration { get; set; }
        [JsonProperty("year")]
        public Int16 Year { get; set; }
        [JsonProperty("produced")]
        public int Produced { get; set; }

        [JsonIgnore]
        public virtual ICollection<Model> Models { get; set; }
    }
}
