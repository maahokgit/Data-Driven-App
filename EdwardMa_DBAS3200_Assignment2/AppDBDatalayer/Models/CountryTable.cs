using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Country")]
    public class CountryTable
    {
        [Key, Column(Order = 0, TypeName = "char"), MaxLength(2)] //custom primary key
        public string Code { get; set; }

        [Required, Column(TypeName ="varchar"), MaxLength(50)]
        public string Name { get; set; }
    }
}
