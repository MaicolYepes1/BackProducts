using System;

namespace Test.MODELS.Entities
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public DateTime DateEnter { get; set; }
        public DateTime DateExit { get; set; }
    }
}
