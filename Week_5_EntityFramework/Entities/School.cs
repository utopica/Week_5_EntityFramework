using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_EntityFramework.Entities
{
    public class School : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=UTOPICA\\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");

        }
    }
}
