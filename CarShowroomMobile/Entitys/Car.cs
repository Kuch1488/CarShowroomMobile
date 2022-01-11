using System;

namespace CarShowroomMobile.Entitys
{
    [Serializable]
    public class Car
    {
        public string VinNumber { get; set; }
        public string Colour { get; set; }
        public decimal Price { get; set; }
        public int IdShowroom { get; set; }
        public int IdModel { get; set; }
    }
}
