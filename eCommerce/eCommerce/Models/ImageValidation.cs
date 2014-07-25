using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//step 1 add using for this

namespace eCommerce.Models
{
[MetadataType(typeof(ImageValidation))]//step 3 is add metadata annotation
    public partial class Image//step 2 is to make a partial class of Category
    {

    }
    public class ImageValidation
    {
        public string ImageURL { get; set; }
        [Required]
        public string Description { get; set; }
    }
}