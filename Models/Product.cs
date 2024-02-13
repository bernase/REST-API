namespace REST_API.Models
{
    public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    // Foreign key for User
    public int UserId { get; set; }

    // Navigation property
    public User User { get; set; }
}
}