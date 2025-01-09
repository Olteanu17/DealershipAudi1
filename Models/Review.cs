using System.ComponentModel.DataAnnotations;

namespace DealershipAudi.Models
{
    public class Review
    {
        public int ID { get; set; }

        [Required]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public int CarID { get; set; }
        public Car Car { get; set; }

        [StringLength(500)]
        public string ReviewText { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }
    }
}
