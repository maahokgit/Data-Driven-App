using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    public class ApplicationTable
    {
        [Key]
        public int ApplicationId { get; set; }

        public DateTime SubmissionDate { get; set; }

        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }
        public ApplicantTable Applicant { get; set; }

        public int ApplicationFee { get; set; }

        public Boolean Paid { get; set; }
    }
}
