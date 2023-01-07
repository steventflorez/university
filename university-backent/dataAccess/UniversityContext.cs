using Microsoft.EntityFrameworkCore;
using university_backent.Models.DataModels;

namespace university_backent.dataAccess
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {

        }

        public DbSet<User>? Users { get; set; }
        public DbSet<curso> Cursos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
    }
}
