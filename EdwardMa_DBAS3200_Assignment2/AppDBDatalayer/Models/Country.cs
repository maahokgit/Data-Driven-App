using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Country")]
    public class Country
    {
        [Key, Column(Order = 0, TypeName = "char"), MaxLength(2), DatabaseGenerated(DatabaseGeneratedOption.None)] //custom primary key
        public string Code { get; set; }

        [Required, Column(TypeName ="varchar"), MaxLength(50)]
        public string Name { get; set; }

        public ICollection<ProvinceState> ProvinceState { get; set; }
        public ICollection<Applicant> Applicants { get; set; }
    }
}