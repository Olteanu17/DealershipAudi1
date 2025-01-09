using System.ComponentModel.DataAnnotations;

namespace DealershipAudi.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Position { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
