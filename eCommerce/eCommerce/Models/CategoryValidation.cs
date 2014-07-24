using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//step 1 add using for this

namespace eCommerce.Models
{[MetadataType(typeof(CategoryValidation))]//step 3 is add metadata annotation
    public partial class Category//step 2 is to make a partial class of Category
    {

    }
    public class CategoryValidation
    {
        //step 4: get the properties from the edmx.tt file 
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Display(Name="Parent Category")]
        public int ParentID { get; set; }
    }
}