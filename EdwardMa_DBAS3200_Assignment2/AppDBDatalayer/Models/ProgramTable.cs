﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Program")]
    public class ProgramTable
    {
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar"), MaxLength(120)]
        public string Name { get; set; }

        public ICollection<CampusTable> Campus { get; set; }
    }
}
