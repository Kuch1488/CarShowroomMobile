using Newtonsoft.Json;
using System;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class ModelOption
    {
        [JsonProperty("idModel")]
        public int IdModel { get; set; }
        [JsonProperty("idOption")]
        public int IdOption { get; set; }

        public virtual Model IdModelNavigation { get; set; }
        public virtual Option IdOptionNavigation { get; set; }
    }
}
