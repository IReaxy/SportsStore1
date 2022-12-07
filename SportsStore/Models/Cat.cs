namespace SportsStore.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public List<CartProduct> Products { get; set; }
    }
}