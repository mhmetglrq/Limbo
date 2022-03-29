using Limbo.Data.Concrete.EntityFramework.Mappings;
using Limbo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo.Data.Concrete.EntityFramework.Contexts
{
    public class LimboDataContext:DbContext
    {
        public DbSet<Comment> Comments  { get; set; }
        public DbSet<Department> Departments  { get; set; }
        public DbSet<University> Universities  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-3HH1MUA\SQLEXPRESS;Initial Catalog=Limbo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new DepartmentMap());
            modelBuilder.ApplyConfiguration(new UniversityMap());
        }
    }
}
