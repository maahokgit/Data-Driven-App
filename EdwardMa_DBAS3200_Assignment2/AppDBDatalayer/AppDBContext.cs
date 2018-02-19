using System.Data.Entity;
using AppDBDatalayer.Models;

namespace AppDBDatalayer
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("name=AppDB")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<AppDBContext>()
                );
        }

        //define the collections of object
        //in the database....tables
        public DbSet<CampusTable> Campus { get; set; }
        public DbSet<ProgramTable> Program { get; set; }  
        public DbSet<CampusProgramTable> CampusProgram { get; set; }
        public DbSet<CitizenshipTable> Citizenship { get; set; }
        public DbSet<CountryTable> Country { get; set; }
        public DbSet<ProvinceStateTable> ProvinceState { get; set; }
        public DbSet<ApplicantTable> Applicant { get; set; }
        public DbSet<ApplicationTable> Application { get; set; }
        public DbSet<ProgramChoiceTable> ProgramChoice { get; set; }
    }
}
