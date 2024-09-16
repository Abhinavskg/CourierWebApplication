using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourierWebApp.Models
{
    public class Customer
    {
        [Key]
        public int? CustomerId { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        [StringLength(maximumLength:15)]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Customer Email")]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }

        public ICollection<Delivery> Deliveries { get; set; }
    }
}
