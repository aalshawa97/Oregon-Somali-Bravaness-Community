/*
 *Abdullah Mutaz Alshawa
 *App database context
 *6/9/2021
 */
using Lab4WebApplication.Data.Entities;
using System.Data.Entity;

namespace Lab4WebApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        /*
        public AppDbContext(DbContext<AppDbContext> options):base(options)
        {

        }
        */

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new AppDbInitializer());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<Event> Events { get; set; }

        public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
        {

        }
    }
}