using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Model
    {
        public Model()
        {
            Cars = new HashSet<Car>();
        }

        [JsonProperty("idModel")]
        public int IdModel { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonIgnore]
        public int IdBody { get; set; }
        [JsonIgnore]
        public int IdBrand { get; set; }
        [JsonIgnore]
        public int IdClass { get; set; }
        [JsonIgnore]
        public int IdGearbox { get; set; }
        [JsonIgnore]
        public int IdGeneration { get; set; }
        [JsonIgnore]
        public int IdEngine { get; set; }

        [JsonIgnore]
        public virtual ICollection<Car> Cars { get; set; }

        public virtual Body IdBodyNavigation { get; set; }
        public virtual Brand IdBrandNavigation { get; set; }
        public virtual Class IdClassNavigation { get; set; }
        public virtual Gearbox IdGearboxNavigation { get; set; }
        public virtual Generation IdGenerationNavigation { get; set; }
        public virtual Engine IdEngineNavigation { get; set; }
    }
}
