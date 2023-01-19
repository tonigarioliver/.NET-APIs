using Microsoft.EntityFrameworkCore;
using System.Formats.Asn1;
using WebApplication1.Models.DataModels;

namespace WebApplication1.DataAccess
{
    public class UnivesityDBContext:DbContext
    {
        public UnivesityDBContext(DbContextOptions<UnivesityDBContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
    }
}
