﻿using System;
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

        [Required, Column(TypeName ="Date")]
        public DateTime SubmissionDate { get; set; }
        
        public int ApplicationFee { get; set; }

        [Required]
        public Boolean Paid { get; set; }
    }
}
