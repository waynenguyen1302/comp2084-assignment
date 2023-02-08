namespace Assignment.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public String? Description { get; set; }
        public decimal Price { get; set; }
        public String? Image { get; set; }
        public int MenuId { get; set; }

        public Menu? Menu {get; set; }
    }
}
