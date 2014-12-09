using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Jabberwocky.EF.Library.Models;

namespace Jabberwocky.EF.Library.DAL
{
    public class JabberwockyContext : DbContext
    {
        public JabberwockyContext() : base("JabberwockyContext")
        { }

        public DbSet<JuggernautUser> JuggernautUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
