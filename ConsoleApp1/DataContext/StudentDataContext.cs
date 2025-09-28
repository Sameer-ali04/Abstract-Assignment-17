using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataContext
{
    public class StudentDataContext : DbContext
    {
        public StudentDataContext()
        {

        }

        public StudentDataContext(DbContextOptions<StudentDataContext> options) : base(options)
        {
        }

       
        public DbSet<Student> students { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<User> users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=Localhost;Port=5432;Database=NewMigration;User Id=postgres;Password=pass;");
            }
        }

    }
}
