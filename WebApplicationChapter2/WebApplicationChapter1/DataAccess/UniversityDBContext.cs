
using Microsoft.EntityFrameworkCore;
using WebApplicationChapter1.Models.DataModels;

namespace WebApplicationChapter1.DataAccess
{
    public class UnivesityDBContext : DbContext
    {
        public UnivesityDBContext(DbContextOptions<UnivesityDBContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
    }
}