﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Citizenship")]
    public class Citizenship
    {
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar"), MaxLength(50)]
        public string Description { get; set; }

        public ICollection<Applicant> Applicants { get; set; }
    }
}
