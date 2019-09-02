using System.ComponentModel.DataAnnotations;

namespace Pizzaslice.Domain.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        [Required]
        public int UserZipCode { get; set; }

    }
}