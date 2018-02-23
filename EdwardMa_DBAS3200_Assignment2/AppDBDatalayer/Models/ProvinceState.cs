using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("ProvinceState")]
    public class ProvinceState
    {
        [Key, Column(TypeName = "char", Order = 1), MaxLength(2), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Code { get; set; }

        [Key]
        [ForeignKey("Country"), Column(TypeName = "char", Order = 2), MaxLength(2)]
        public string CountryCode { get; set; }
        public Country Country { get; set; }

        [Required, Column(TypeName ="varchar"), MaxLength(50)]
        public string Name { get; set; }
        
        public ICollection<Applicant> Applicants { get; set; }
    }
}
