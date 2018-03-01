using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Campus")]
    public class Campus
    {   
        /// <summary>
        /// Scalar Properties for Campus Table
        /// </summary>
        [Key]
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar"), MaxLength(120)]
        public string Name { get; set; }

        /// <summary>
        /// ICollection for 1:n to Program and ProgramChoice Table.
        /// </summary>
        public ICollection<Program> Programs {get; set;}
        public ICollection<ProgramChoice> ProgramChoices { get; set; }
    }
}
