namespace Assignment.Models
{
    public class Order
    {
        public int Id { get; set; } 
        public String? OrderDate { get; set; }
        public int UserId { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public String? Address { get; set; }
        public String? Province { get; set; }
        public String? PostalCode { get; set; }
        public int PaymentId { get; set; }

        public List<OrderDetail>? OrderDetails { get; set; }

    }
}
