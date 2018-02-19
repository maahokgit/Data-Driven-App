using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    public class CampusProgramTable
    {
        [Key, ForeignKey("Campus")]
        public int CampusId { get; set; }

        [Key, ForeignKey("Program")]
        public int ProgramId { get; set; }

        //navigation properties
        public CampusTable Campus { get; set; }
        public ProgramTable Program { get; set; }
    }
}
