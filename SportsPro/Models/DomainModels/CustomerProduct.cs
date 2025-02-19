﻿//Coded by Matt Biesbroek
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsPro.Models
{
    public class CustomerProduct
    {
        [Required(ErrorMessage = "Please select a product.")]
        public int ProductID { get; set; }
        [Required]
        public int CustomerID { get; set; }

        public Customer Customer { get; set; }
       
        public Product Product { get; set; }
    }
}
