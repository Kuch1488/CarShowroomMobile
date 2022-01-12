using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Car
    {
        public Car()
        {
            StateElements = new HashSet<StateElement>();
        }

        public string VinNumber { get; set; }
        public string Colour { get; set; }
        public decimal Price { get; set; }
        [JsonIgnore]
        public int IdShowroom { get; set; }
        [JsonIgnore]
        public int IdModel { get; set; }

        public virtual Model IdModelNavigation { get; set; }
        public virtual CarShowroom IdShowroomNavigation { get; set; }

        [JsonIgnore]
        public virtual ICollection<StateElement> StateElements { get; set; }
    }
}
