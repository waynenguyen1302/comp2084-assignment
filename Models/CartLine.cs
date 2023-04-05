using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class CartLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        [Required]
        public String? CustomerId { get; set; }

        public int DishId { get; set; }

        public Dish? Dish { get; set; }
    }
}
