using System;

namespace Domain
{
    /// <summary>
    /// Class describes product properties
    /// </summary>
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public double TotalPrice { get; set; }

        public string Type { get; set; }

        public DateTime Date { get; set; }
    }
}
