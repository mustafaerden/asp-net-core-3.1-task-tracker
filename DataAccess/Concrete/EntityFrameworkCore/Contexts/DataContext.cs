using DataAccess.Concrete.EntityFrameworkCore.TableConfigs;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class DataContext : IdentityDbContext<AppUser, AppRole, int>
    {
        // shortcut: override onConf
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=NKatmanliTaskFollow; integrated security=true;");

            // identity i ekledikten sonra bunu da ekledik;
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserTableConfig());
            modelBuilder.ApplyConfiguration(new TaskTableConfig());
            modelBuilder.ApplyConfiguration(new UrgencyTableConfig());
            modelBuilder.ApplyConfiguration(new ReportTableConfig());

            // identity i ekledikten sonra bunu da ekledik;
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Urgency> Urgencies { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
