using Microsoft.EntityFrameworkCore;

namespace REST_API_With_SQL_SERVER.Data
{
    public class CollageDBcontext : DbContext
    {
        public CollageDBcontext(DbContextOptions<CollageDBcontext> options):base(options) { 
        
        
        
        }
        

        
        DbSet<Student> students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Student>().HasData(new List<Student>
    {
        new Student
        {
            Id = 1,
            Name = "Mihir Gupta",
            Email = "Mihirkumargupta2@gmail.com"
        },
        new Student
        {
            Id = 2,
            Name = "Khushi Gupta",
            Email = "Khushigupta2@gmail.com"
        },
        new Student
        {
            Id = 3,
            Name = "Anjali Shaw",
            Email = "Anjalishaw4@gmail.com"
        }
    });
        }


    }
}
