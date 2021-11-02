using Microsoft.EntityFrameworkCore;
using Session9_DataAccess.Models;

namespace Session9_DataAccess.DataAccess
{
    public class DBContext: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Programme> Programmes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Name of database
            optionsBuilder.UseSqlite("Data Source = C:/Users/LineK/RiderProjects/Solution1/Session9_DataAccess/VIA.db");
        }
    }
}