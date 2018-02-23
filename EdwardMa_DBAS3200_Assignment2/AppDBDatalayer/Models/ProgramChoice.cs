using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("ProgramChoice")]
    public class ProgramChoice
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public Program Program { get; set; }

        [ForeignKey("Campus")]
        public int CampusId { get; set; }
        public Campus Campus { get; set; }

        [Required]
        public int Preference { get; set; }
    }
}
