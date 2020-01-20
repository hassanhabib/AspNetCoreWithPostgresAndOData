using Microsoft.EntityFrameworkCore;
using Students.Api.Models;

namespace Students.Api.Brokers
{
    public class StorageBroker : DbContext
    {
        public StorageBroker(DbContextOptions<StorageBroker> options)
            : base(options) => this.Database.Migrate();

        public DbSet<Student> Students { get; set; }
    }
}
