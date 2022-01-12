using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class State
    {
        public State()
        {
            StateElements = new HashSet<StateElement>();
        }

        public int IdState { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<StateElement> StateElements { get; set; }
    }
}
