using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDAC_Assignment.Models
{
    public class OrderFullInfo
    {
        public Order order { get; set; }
        public List<OrderProduct> orderProducts { get; set; }
    }
}
