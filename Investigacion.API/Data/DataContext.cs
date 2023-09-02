using Investigacion.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Investigacion.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ProyectInvest> ProyectInvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProyectInvest>().HasIndex(c => c.Id).IsUnique();
        }

    }
}
