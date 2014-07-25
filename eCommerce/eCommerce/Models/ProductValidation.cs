using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//step 1 add using for this

namespace eCommerce.Models
{
    [MetadataType(typeof(ProductValidation))]//step 3 is add metadata annotation
    public partial class Product//step 2 is to make a partial class of Category
    {

    }
    public class ProductValidation
    {[Required, MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Nullable<decimal> UnitPrice { get; set; }
        [Required]
        public decimal ListPrice { get; set; }
        [Required]
        public bool InStock { get; set; }
    }
}