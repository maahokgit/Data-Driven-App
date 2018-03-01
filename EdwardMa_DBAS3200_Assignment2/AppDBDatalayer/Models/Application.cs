using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Application")]
    public class Application
    {
        /// <summary>
        /// Scalar Properties for Application Table
        /// </summary>
        [Key, ForeignKey("Applicant")]
        public int ApplicationId { get; set; }

        [Required, Column(TypeName ="Date")]
        public DateTime SubmissionDate { get; set; }
        
        public int ApplicationFee { get; set; }

        [Required]
        public Boolean Paid { get; set; }

        /// <summary>
        /// Navigation Properties 
        /// </summary>
        public Applicant Applicant { get; set; }

        /// <summary>
        /// ICollection to set up 1:n relationship
        /// </summary>
        public ICollection<ProgramChoice> ProgramChoices { get; set; }
    }
}
