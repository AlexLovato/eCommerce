using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Cart
    {
        [Key]
        public int ProductId { get; set; }
        public string CartId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}