using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("ProvinceState")]
    public class ProvinceState
    {
        /// <summary>
        /// Scalar Properties for ProvinceState Table
        /// </summary>
        /// 

        [Key, Column(TypeName = "char", Order = 1), MaxLength(2), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Code { get; set; }

        [Key]
        [Required,ForeignKey("Country"), Column(TypeName = "char", Order = 2), MaxLength(2)]
        public string CountryCode { get; set; }

        [Required, Column(TypeName ="varchar"), MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Navigation Properties
        /// </summary>
        /// 

        // for CountryCode
        public Country Country { get; set; }

        /// <summary>
        /// Set up 1:n to Applicant Table
        /// </summary>
        public ICollection<Applicant> Applicants { get; set; }
    }
}
