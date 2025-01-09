using System.ComponentModel.DataAnnotations;

namespace DealershipAudi.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        public ICollection<Sale>? Sales { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
