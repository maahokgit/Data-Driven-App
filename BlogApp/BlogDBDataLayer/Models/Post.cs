using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogDBDataLayer.Models
{
    public class Post
    {
        //scalar properties. contain values
        public int PostID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        [ForeignKey("Blog")]
        public int BlogID { get; set; }
        //navigation properties

        public Blog Blog { get; set; }
    }
}
