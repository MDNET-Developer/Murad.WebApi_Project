using System;

namespace Murad.WebApi.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
