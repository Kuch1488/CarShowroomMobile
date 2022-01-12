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

        public int IdShowroom { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public virtual ICollection<Car> Cars { get; set; }
    }
}
