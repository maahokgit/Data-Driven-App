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

        public DbSet<Campus> Campus { get; set; }
        public DbSet<Program> Program { get; set; }  
        public DbSet<Citizenship> Citizenship { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<ProvinceState> ProvinceState { get; set; }
        public DbSet<Applicant> Applicant { get; set; }
        public DbSet<Application> Application { get; set; }
        public DbSet<ProgramChoice> ProgramChoice { get; set; }

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
