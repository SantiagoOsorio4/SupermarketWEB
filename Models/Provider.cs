using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.Models
{
    public class Provider
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string? FirstName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        public string? Company { get; set; } 
    }
}
