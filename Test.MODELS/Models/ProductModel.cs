using System;

namespace Test.MODELS.Models
{
    public class ProductModel
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public DateTime DateEnter { get; set; }
        public DateTime DateExit { get; set; }
    }
}
