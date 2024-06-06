namespace REST_API.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        // Foreign key - User
        public int UserId { get; set; }

        // Navigation property
        public User User { get; set; }
    }
}