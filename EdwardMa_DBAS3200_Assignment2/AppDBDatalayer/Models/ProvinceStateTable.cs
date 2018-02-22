using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("ProvinceState")]
    public class ProvinceStateTable
    {
        [Key, Column(TypeName = "char"), MaxLength(2), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Code { get; set; }

        [ForeignKey("Country"), Column(TypeName = "char"), MaxLength(2)]
        public string CountryCode { get; set; }
        public CountryTable Country { get; set; }

        [Required, Column(TypeName ="varchar"), MaxLength(50)]
        public string Name { get; set; }
    }
}
