﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDBDatalayer.Models
{
    [Table("Applicant")]
    public class ApplicantTable
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

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required, ForeignKey("Genders"), MaxLength(2)]
        public string Gender { get; set; }
        public GenderTable Genders { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string GenderOther { get; set; }

        [Required, Column(TypeName = "nvarchar"), MaxLength(50)]
        public string StreetAddress { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string StreetAddress2 { get; set; }

        [Required, Column(TypeName = "nvarchar"), MaxLength(50)]
        public string City { get; set; }

        [ForeignKey("ProvinceState")]
        public string ProvinceStateCode { get; set; }
        public ProvinceStateTable ProvinceState { get; set; }

        [Column(TypeName = "nvarchar"), MaxLength(50)]
        public string ProvinceStateOther { get; set; }

        [ForeignKey("Country")]
        public string CountryCode { get; set; }
        public CountryTable Country { get; set; }

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

        [ForeignKey("Citizen")]
        public int Citizenship { get; set; }
        public CitizenshipTable Citizen { get; set; }

        [ForeignKey("CountryOther")]
        public string CitizenshipOther { get; set; }
        public CountryTable CountryOther { get; set; }

        public Boolean HasCriminalRecord { get; set; }

        [Required]
        public Boolean IsIndigenous { get; set; }

        [Required]
        public Boolean IsAfricanCanadian { get; set; }

        [Required]
        public Boolean HasDisability { get; set; }
    }
}
