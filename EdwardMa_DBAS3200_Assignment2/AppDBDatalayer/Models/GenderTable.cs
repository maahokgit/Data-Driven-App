using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppDBDatalayer.Models
{
    [Table("Gender")]
    public class GenderTable
    {
        [Key, Column(TypeName ="varchar"), MaxLength(2), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Code { get; set; }

        [Column(TypeName ="varchar"), MaxLength(50)]
        public string Description { get; set; }
    }
}
