using System.Collections.Generic;

namespace REST_API.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
