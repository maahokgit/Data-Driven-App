using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    public class ApplicantTable
    {
        [Key] //redundant...but it's so i know it's a PK
        public int Applicantid { get; set; }

        public string SIN { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string FirstNamePreferred { get; set; }
        public string LastNamePreferred { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string GenderOther { get; set; }

        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }

        [ForeignKey("ProvinceState")]
        public string ProvinceStateCode { get; set; }
        public ProvinceStateTable ProvinceState { get; set; }

        public string ProvinceStateOther { get; set; }

        [ForeignKey("Country")]
        public string CountryCode { get; set; }
        public CountryTable Country { get; set; }

        public string PhoneHome { get; set; }
        public string PhoneCell { get; set; }

        public string EmailAddress { get; set; }

        public string NSCCStudentId { get; set; }

        public Boolean IsEnglishFirstLanguage { get; set; }

        public string FirstLanguageOther { get; set; }

        [ForeignKey("Citizen")]
        public string Citizenship { get; set; }

        [ForeignKey("Country")]
        public string CitizenshipOther { get; set; }

        public Boolean HasCriminalRecord { get; set; }
        public Boolean IsIndigenous { get; set; }
        public Boolean IsAfricanCanadian { get; set; }
        public bool HasDisability { get; set; }
    }
}
