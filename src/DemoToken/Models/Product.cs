using System;

namespace DemoToken.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Value { get; set; }
        public DateTime DateRegister { get; set; }
    }
}
