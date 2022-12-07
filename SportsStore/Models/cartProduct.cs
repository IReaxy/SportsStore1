using SportStore.Models;

namespace SportsStore.Models
{
    public class CartProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Product Product { get; set; }
    }
}