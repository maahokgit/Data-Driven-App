using System.ComponentModel.DataAnnotations;

namespace AppDBDatalayer.Models
{
    class CountryTable
    {
        [Key] //custom primary key
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
