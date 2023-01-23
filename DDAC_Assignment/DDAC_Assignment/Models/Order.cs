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
        public int UserID { get; set; }
        public int ConntactID { get; set; }
        public int ProductID { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string DeliveryStatus { get; set; }
    }
}
