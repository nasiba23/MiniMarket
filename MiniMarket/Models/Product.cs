using System.ComponentModel.DataAnnotations.Schema;

namespace MiniMarket.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("Category")]
        public long CategoryId { get; set; }
    }
}