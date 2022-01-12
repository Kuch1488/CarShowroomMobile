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

        public int IdGeneration { get; set; }
        public Int16 Year { get; set; }
        public int Produced { get; set; }

        [JsonIgnore]
        public virtual ICollection<Model> Models { get; set; }
    }
}
