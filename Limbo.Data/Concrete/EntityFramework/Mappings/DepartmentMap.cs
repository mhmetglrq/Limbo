using Limbo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo.Data.Concrete.EntityFramework.Mappings
{
    public class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d=> d.Id).ValueGeneratedOnAdd();
            builder.Property(d => d.Name).IsRequired();
            builder.Property(d => d.Name).HasMaxLength(75);
            builder.Property(d => d.NegativeCount).IsRequired();
            builder.Property(d=>d.PositiveCount).IsRequired();
            builder.Property(d=>d.IsActive).IsRequired();
            builder.Property(d=>d.IsDeleted).IsRequired();
            builder.HasOne<University>(d=>d.University).WithMany(u=>u.Departments).HasForeignKey(u=>u.UniversityId);
            builder.ToTable("Departments");
        }
    }
}
