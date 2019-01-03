using Microsoft.EntityFrameworkCore;
using Contoso.Models;

namespace Contoso.Data
{
    public class ContosoContext : DbContext
    {
        public ContosoContext(DbContextOptions<ContosoContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}