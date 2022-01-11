using System;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class StateElement
    {
        public int IdStateElement { get; set; }
        public string Name { get; set; }
        public string VinNumber { get; set; }
        public int IdState { get; set; }
    }
}
