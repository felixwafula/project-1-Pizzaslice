using System.ComponentModel.DataAnnotations;

namespace Pizzaslice.Domain.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Must be at least 8 characters.")]
        [StringLength(20, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        [Required(ErrorMessage = "Must be at least 5 digits.")]
        public int UserZipCode { get; set; }

    }
}