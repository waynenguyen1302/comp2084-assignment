namespace Assignment.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int DishId { get; set; }
        public int UserId { get; set; }
        public Dish? Dish { get; set; }
        public Order? Order { get; set; }
    }
}
