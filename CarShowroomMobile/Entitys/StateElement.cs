using Newtonsoft.Json;
using System;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class StateElement
    {
        public int IdStateElement { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public string VinNumber { get; set; }
        [JsonIgnore]
        public int IdState { get; set; }

        public virtual Car IdCarNavigation { get; set; }
        public virtual State IdStateNavigation { get; set; }
    }
}
