using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Brand
    {
        public Brand()
        {
            Models = new HashSet<Model>();
        }

        public int IdBrand { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Model> Models { get; set; }
    }
}
