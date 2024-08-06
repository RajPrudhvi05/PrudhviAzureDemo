using Microsoft.EntityFrameworkCore;
using PrudhviProject.Model;

namespace PrudhviProject.DbFiles
{
    public class StudentDb:DbContext
    {
        public StudentDb(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> students {  get; set; }


    }
}
