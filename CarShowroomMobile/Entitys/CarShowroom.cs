using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class CarShowroom
    {
        public CarShowroom()
        {
            Cars = new HashSet<Car>();
        }

        [JsonProperty("idShowroom")]
        public int IdShowroom { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonIgnore]
        public virtual ICollection<Car> Cars { get; set; }
    }
}
