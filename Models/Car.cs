using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealershipAudi.Models
{
    public class Car
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(50)]
        public string Manufacturer { get; set; } = "Audi";

        [Range(0.01, 200000)]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        [Range(1900, 2100)]
        public int Year { get; set; }

        public ICollection<Sale>? Sales { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
