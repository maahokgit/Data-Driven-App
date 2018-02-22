using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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
        public DbSet<CitizenshipTable> Citizenship { get; set; }
        public DbSet<GenderTable> Gender { get; set; }
        public DbSet<CountryTable> Country { get; set; }
        public DbSet<ProvinceStateTable> ProvinceState { get; set; }
        public DbSet<ApplicantTable> Applicant { get; set; }
        public DbSet<ApplicationTable> Application { get; set; }
        public DbSet<ProgramChoiceTable> ProgramChoice { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CampusTable>()
                        .HasMany(p => p.Program)
                        .WithMany(c => c.Campus)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("CampusId");
                            cs.MapRightKey("ProgramId");
                            cs.ToTable("CampusProgram");
                        });

        }
    }
}
