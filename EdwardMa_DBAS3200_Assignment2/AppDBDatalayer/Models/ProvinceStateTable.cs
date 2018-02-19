using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    public class ProvinceStateTable
    {
        [Key, Column(Order = 0)]
        public string Code { get; set; }

        [ForeignKey("Country"), Column(Order = 1)]
        public string CountryCode { get; set; }

        //navigation properties
        public CountryTable Country { get; set; }
    }
}
