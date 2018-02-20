using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Campus")]
    public class CampusTable
    {
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar"), MaxLength(50)]
        public string Name { get; set; }
    }
}
