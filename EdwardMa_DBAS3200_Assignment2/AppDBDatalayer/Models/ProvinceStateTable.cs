using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    public class ProvinceStateTable
    {
        [Key]
        public string Code { get; set; }

        [Key, ForeignKey("Country")]
        public string CountryCode { get; set; }

        //navigation properties
        public CountryTable Country { get; set; }
    }
}
