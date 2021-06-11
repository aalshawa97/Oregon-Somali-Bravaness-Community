/*Abdullah Mutaz Alshawa
 * 6/9/2021
 * Login view model
 */
using System.Data.Entity;

namespace Lab4WebApplication.Models.View
{
    public partial class LoginViewModel : DbContext
    {
        public LoginViewModel()
            : base("name=LoginViewModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        /*
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        */

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
