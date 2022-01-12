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

        public int IdGearbox { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }

        [JsonIgnore]
        public virtual ICollection<Model> Models { get; set; }
    }
}
