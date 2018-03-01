using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Program")]
    public class Program
    {
        /// <summary>
        /// Scalar Properties for Program Table
        /// </summary>
        [Key]
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar"), MaxLength(120)]
        public string Name { get; set; }

        /// <summary>
        /// Set up 1:n to Campus, and ProgramChoice Table
        /// </summary>
        public ICollection<Campus> Campuses { get; set; }
        public ICollection<ProgramChoice> ProgramChoices { get; set; }
    }
}
