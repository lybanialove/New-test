using Microsoft.EntityFrameworkCore;
using TestProject.Shared.Entitys;

namespace TestProject.Shared.Database
{
    public class Context : DbContext
    {
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Task_> Tasks { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
