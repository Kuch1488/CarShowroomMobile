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

        public int IdEngine { get; set; }
        public string Type { get; set; }
        public int Volume { get; set; }
        public int HP { get; set; }
        public int Consumption { get; set; }

        [JsonIgnore]
        public virtual ICollection<Model> Models { get; set; }
    }
}
