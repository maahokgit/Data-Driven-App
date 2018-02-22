﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Campus")]
    public class CampusTable
    {
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar"), MaxLength(120)]
        public string Name { get; set; }

        public ICollection<ProgramTable> Program {get; set;}
    }
}
