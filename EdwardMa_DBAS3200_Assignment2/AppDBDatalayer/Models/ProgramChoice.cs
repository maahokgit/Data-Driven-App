using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("ProgramChoice")]
    public class ProgramChoice
    {
        /// <summary>
        /// Scalar Properties for ProgramChoice
        /// </summary>
        /// 

        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("Application")]
        public int ApplicationId { get; set; }

        [Required, ForeignKey("Program")]
        public int ProgramId { get; set; }

        [Required, ForeignKey("Campus")]
        public int CampusId { get; set; }

        [Required]
        public int Preference { get; set; }

        /// <summary>
        /// Navigation Properties
        /// </summary>
        /// 

        // for ApplicationId
        public Application Application { get; set; }

        // for ProgramId
        public Program Program { get; set; }

        // for CampusId
        public Campus Campus { get; set; }        
    }
}
