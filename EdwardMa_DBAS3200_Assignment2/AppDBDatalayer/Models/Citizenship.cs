using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Citizenship")]
    public class Citizenship
    {
        /// <summary>
        /// Scalar Properties for Citizenship Table
        /// </summary>
        [Key]
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar"), MaxLength(50)]
        public string Description { get; set; }

        /// <summary>
        /// ICollection for 1:n to Applicant Table.
        /// </summary>
        public ICollection<Applicant> Applicants { get; set; }
    }
}
