using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealershipAudi.Models
{
    public class Sale
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Car selection is required.")]
        public int CarID { get; set; }
        public Car Car { get; set; }

        [Required(ErrorMessage = "Customer selection is required.")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [Required(ErrorMessage = "Sale date is required.")]
        [DataType(DataType.Date)]
        public DateTime SaleDate { get; set; }

        [Required(ErrorMessage = "Total price is required.")]
        [Column(TypeName = "decimal(10, 2)")]
        [Range(0.01, 2000000, ErrorMessage = "Total price must be between 0.01 and 2,000,000.")]
        public decimal TotalPrice { get; set; }
    }
}
