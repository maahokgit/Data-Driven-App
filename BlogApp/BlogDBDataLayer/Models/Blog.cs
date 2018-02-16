using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogDBDataLayer.Models
{
    public class Blog
    {
        //scalar properties
        public int BlogID { get; set; }

        [Required]
        public string Title { get; set; }

        //navigation properties
        public ICollection<Post> Posts { get; set; }
    }
}
