

namespace Assignment.Models
{
    public class Menu
    {
        public int Id { get; set; }

        public String? Name { get; set; }   

        public String? Description { get; set; }

        public List<Dish>? Dishes { get; set; }

    }
}
