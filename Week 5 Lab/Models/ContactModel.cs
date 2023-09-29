using System.ComponentModel.DataAnnotations;

namespace VioletsLoops.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Please enter a first name.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter a valid address.")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Please enter a valid phone number.")]
        [Range(1000000000, 9999999999, ErrorMessage ="Phone number must be 10 digets long")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please tell us how we can help you.")]
        public string? Message { get; set; }
    }
}
