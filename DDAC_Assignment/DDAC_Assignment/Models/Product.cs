using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DDAC_Assignment.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string ProductType { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }

        [Required]
        public decimal ProductRating { get; set; }

        [Required]
        public string ProductURL { get; set; }

        [Required]
        public string ProductS3Key { get; set; }
    }
}
