using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("CampusProgram")]
    public class CampusProgramTable
    {
        [Key, ForeignKey("Campus"), Column(Order = 0)]
        public int CampusId { get; set; }

        [Key, ForeignKey("Program"), Column(Order = 1)]
        public int ProgramId { get; set; }

        //navigation properties
        public CampusTable Campus { get; set; }
        public ProgramTable Program { get; set; }
    }
}
