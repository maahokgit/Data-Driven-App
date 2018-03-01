using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppDBDatalayer.Models
{
    [Table("Gender")]
    public class Gender
    {
        /// <summary>
        /// Scalar Properties for Gender Table
        /// </summary>
        
        // customized Primary Key
        [Key, Column(TypeName ="varchar"), MaxLength(2), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Code { get; set; }

        [Required, Column(TypeName ="varchar"), MaxLength(50)]
        public string Description { get; set; }

        /// <summary>
        /// set up 1:n to Applicant Table
        /// </summary>
        public ICollection<Applicant> Applicants { get; set; }
    }
}
