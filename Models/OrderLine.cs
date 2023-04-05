using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class OrderLine
    {
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }


        [Required]
        public int DishId { get; set; }

        [Required]
        public int OrderId { get; set; }

        public Dish? Dish { get; set; }
        public Order? Order { get; set; }
    }
}
