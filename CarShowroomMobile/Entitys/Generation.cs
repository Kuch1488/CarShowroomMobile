using System;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Generation
    {
        public int IdGeneration { get; set; }
        public Int16 Year { get; set; }
        public int Produced { get; set; }
    }
}
