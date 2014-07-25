using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//step 1 add using for this

namespace eCommerce.Models
{
    [MetadataType(typeof(ReviewValidation))]//step 3 is add metadata annotation
    public partial class Review//step 2 is to make a partial class of Category
    {

    }
    public class ReviewValidation
    {[Required]
        public string Username { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public System.DateTime DateCreated { get; set; }
    }
}