using Microsoft.EntityFrameworkCore;

namespace  MyCollage_EF_Rep_AsyncAwait.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {
        }
       public DbSet<Student> Students {get; set;}
       public DbSet<Course> Courses{get; set;}
       public DbSet<Register> Registers {get; set;}
    }
}