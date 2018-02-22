using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Application")]
    public class ApplicationTable
    {
        [Key, ForeignKey("Applicant")]
        public int ApplicationId { get; set; }
        public ApplicantTable Applicant { get; set; }

        public DateTime SubmissionDate { get; set; }
        
        public int ApplicationFee { get; set; }

        public Boolean Paid { get; set; }
    }
}
