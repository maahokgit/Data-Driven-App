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

        /// <summary>
        /// define the collections of objects in the database aka Tables
        /// </summary>
        /// 

        public DbSet<Campus> Campuses { get; set; }
        public DbSet<Program> Programs { get; set; }  
        public DbSet<Citizenship> Citizenships { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ProvinceState> ProvinceStates { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<ProgramChoice> ProgramChoices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //creating junction table between Campus and Program Table
            modelBuilder.Entity<Campus>()
                        .HasMany(p => p.Programs)
                        .WithMany(c => c.Campuses)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("CampusId");
                            cs.MapRightKey("ProgramId");
                            cs.ToTable("CampusProgram"); //customized Name for Junction Table
                        });
        }
    }
}
