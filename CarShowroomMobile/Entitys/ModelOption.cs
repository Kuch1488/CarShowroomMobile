using System;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class ModelOption
    {
        public int IdModel { get; set; }
        public int IdOption { get; set; }

        public virtual Model IdModelNavigation { get; set; }
        public virtual Option IdOptionNavigation { get; set; }
    }
}
