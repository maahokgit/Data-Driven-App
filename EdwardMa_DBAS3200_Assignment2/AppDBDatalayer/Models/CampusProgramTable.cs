using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDBDatalayer.Models
{
    class CampusProgramTable
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
