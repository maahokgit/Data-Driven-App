using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Program")]
    public class Program
    {
        [Key]
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar"), MaxLength(120)]
        public string Name { get; set; }

        public ICollection<Campus> Campuses { get; set; }
        public ICollection<ProgramChoice> ProgramChoices { get; set; }
    }
}
