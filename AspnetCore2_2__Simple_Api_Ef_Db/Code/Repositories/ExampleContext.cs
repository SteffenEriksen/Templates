using Microsoft.EntityFrameworkCore;
using template.Entities.Models;

namespace template.Repositories
{
    public class ExampleContext : DbContext
    {
        public ExampleContext(DbContextOptions<ExampleContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExampleModel>().HasKey(e => e.Id);
            //modelBuilder.Entity<ExampleModel>().Property(e => e.Created).IsRequired();
            //modelBuilder.Entity<ExampleModel>().Property(e => e.Id).HasMaxLength(36);
        }




        public DbSet<ExampleModel> ExampleModels { get; set; }
    }
}
