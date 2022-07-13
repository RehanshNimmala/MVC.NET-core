using Microsoft.EntityFrameworkCore;

namespace NimmalaWeek6.Models
{
    public class HogwartsContext:DbContext
    {
        public HogwartsContext(DbContextOptions<HogwartsContext>options):base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> enrollments { get; set; }
        public DbSet<Student> students { get; set; }
    }
}
