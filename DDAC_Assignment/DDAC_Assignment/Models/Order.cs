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
        public DateTime DatePlacedOn { get; set; }
        public string UserID { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string DeliveryStatus { get; set; }
        public string DeliveryContact { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime EstimatedArrivalDate { get; set; }
    }
}
