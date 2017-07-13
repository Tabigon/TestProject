using System.Data.Entity;
using TestProject.Domain;

namespace TestProject.DAL
{
    public class AppContext : DbContext
    {
        public DbSet<Record> Records { get; set; }
    }
}
