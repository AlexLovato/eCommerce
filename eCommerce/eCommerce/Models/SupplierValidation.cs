using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace eCommerce.Models
{
    [MetadataType(typeof(SupplierValidation))]//step 3 is add metadata annotation
    public partial class Supplier //step 2 is to make a partial class of Category
    {

    }
    public class SupplierValidation
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}