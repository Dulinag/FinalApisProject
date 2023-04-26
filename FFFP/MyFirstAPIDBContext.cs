using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FFFP.Models
{
    public class MyFirstAPIDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public MyFirstAPIDBContext(DbContextOptions<MyFirstAPIDBContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("MyHospitalDB9");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Patients> Patients { get; set; } = null!;
        public DbSet<Doctors> Doctors { get; set; } = null!;
        public DbSet<Appointments> Appointments { get; set; } = null!;
    }
}
