using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Country")]
    public class Country
    {
        /// <summary>
        /// Scalar Properties for Country Table
        /// </summary>
        [Key, Column(TypeName = "char"), MaxLength(2), DatabaseGenerated(DatabaseGeneratedOption.None)] //custom primary key
        public string Code { get; set; }

        [Required, Column(TypeName ="varchar"), MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// ICollection to set up 1:n to ProvinceState and Applicant Table
        /// </summary>
        public ICollection<ProvinceState> ProvinceStates { get; set; }

        [ForeignKey("CountryCode")] // to FK in Applicant Table
        public ICollection<Applicant> Applicants { get; set; }
    }
}