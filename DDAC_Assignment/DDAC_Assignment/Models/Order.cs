using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DDAC_Assignment.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public DateTime DatePlacedOn { get; set; }

        [Required]
        public string UserID { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public string PaymentMethod { get; set; }

        [Required]
        public string PaymentStatus { get; set; }

        [Required]
        public string DeliveryStatus { get; set; }

        [Required]
        public string DeliveryContact { get; set; }

        [Required]
        public string DeliveryAddress { get; set; }

        [Required]
        public DateTime EstimatedArrivalDate { get; set; }
    }
}
