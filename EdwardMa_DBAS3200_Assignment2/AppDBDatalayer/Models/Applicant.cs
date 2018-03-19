using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Applicant")]
    public class Applicant
    {   
        /// <summary>
        /// Scalar Properties for Applicant
        /// </summary>

        [Key]
        public int Applicantid { get; set; }

        [Column(Order = 0, TypeName = "varchar"), MaxLength(10)]
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

        [ForeignKey("Genders"), MaxLength(2)]
        public string Gender { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string GenderOther { get; set; }

        [Required, Column(TypeName = "nvarchar"), MaxLength(50)]
        public string StreetAddress1 { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string StreetAddress2 { get; set; }

        [Required, Column(TypeName = "nvarchar"), MaxLength(50)]
        public string City { get; set; }

        public string ProvinceStateCode { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string ProvinceStateOther { get; set; }

        [Required, ForeignKey("Country")]
        public string CountryCode { get; set; }

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
        
        [ForeignKey("CountryOther")]
        public string CitizenshipOther { get; set; }

        [Required]
        public Boolean HasCriminalRecord { get; set; }

        [Required]
        public Boolean IsIndigenous { get; set; }

        [Required]
        public Boolean IsAfricanCanadian { get; set; }

        [Required]
        public Boolean HasDisability { get; set; }


        /// <summary>
        /// Navigation Properties
        /// </summary>
        /// 

        // for Gender
        public Gender Genders { get; set; }

        // composite key for ProvinceStateCode
        [ForeignKey("ProvinceStateCode, CountryCode")]
        public ProvinceState ProvinceState { get; set; }

        // for CountryCode
        public Country Country { get; set; }

        // for Citizenship
        public Citizenship Citizen { get; set; }

        // for CitizenshipOther
        public Country CountryOther { get; set; }
    }
}
