using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Applicant")]
    public class Applicant
    {   
        [Key] //redundant...but it's so i know it's a PK
        public int Applicantid { get; set; }

        [Column(TypeName = "varchar"), MaxLength(10)]
        public string SIN { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string Prefix { get; set; }

        [Required, Column(TypeName = "nvarchar"), MaxLength(50)]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string MiddleName { get; set; }

        [Required, Column(TypeName = "nvarchar"), MaxLength(50)]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string FirstNamePreferred { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string LastNamePreferred { get; set; }

        [Required, Column(TypeName ="Date")]
        public DateTime DateOfBirth { get; set; }

        [Required, ForeignKey("Genders"), MaxLength(2)]
        public string Gender { get; set; }
        public Gender Genders { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string GenderOther { get; set; }

        [Required, Column(TypeName = "nvarchar"), MaxLength(50)]
        public string StreetAddress1 { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string StreetAddress2 { get; set; }

        [Required, Column(TypeName = "nvarchar"), MaxLength(50)]
        public string City { get; set; }

        
        public string ProvinceStateCode { get; set; }

        // composite key, nav properties
        [ForeignKey("ProvinceStateCode, CountryCode")]
        public ProvinceState ProvinceState { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string ProvinceStateOther { get; set; }

        public string CountryCode { get; set; }
        [Required, ForeignKey("CountryCode")]
        public Country Country { get; set; }

        [Required, Column(TypeName = "varchar"), MaxLength(20)]
        public string PhoneHome { get; set; }

        [Column(TypeName = "varchar"), MaxLength(20)]
        public string PhoneCell { get; set; }

        [Required, Column(TypeName = "nvarchar"), MaxLength(50)]
        public string EmailAddress { get; set; }

        [Column(TypeName = "char"), MaxLength(7)]
        public string NSCCStudentId { get; set; }

        [Required]
        public Boolean IsEnglishFirstLanguage { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(20)]
        public string FirstLanguageOther { get; set; }

        [Required, ForeignKey("Citizen")]
        public int Citizenship { get; set; }
        public Citizenship Citizen { get; set; }

        [ForeignKey("CountryOther")]
        public string CitizenshipOther { get; set; }
        public Country CountryOther { get; set; }

        [Required]
        public Boolean HasCriminalRecord { get; set; }

        [Required]
        public Boolean IsIndigenous { get; set; }

        [Required]
        public Boolean IsAfricanCanadian { get; set; }

        [Required]
        public Boolean HasDisability { get; set; }
    }
}
