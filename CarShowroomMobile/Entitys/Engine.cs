using System;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Engine
    {
        public int IdEngine { get; set; }
        public string Type { get; set; }
        public int Volume { get; set; }
        public int HP { get; set; }
        public int Consumption { get; set; }
    }
}
