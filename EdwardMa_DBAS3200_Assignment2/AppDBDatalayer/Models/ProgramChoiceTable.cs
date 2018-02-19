using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    public class ProgramChoiceTable
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        public ApplicationTable Application { get; set; }

        [ForeignKey("Program")]
        public int ProgramId { get; set; }
        public ProgramTable Program { get; set; }

        [ForeignKey("Campus")]
        public int CampusId { get; set; }
        public CampusTable Campus { get; set; }
    }
}
