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
    public class UniversityMap : IEntityTypeConfiguration<University>
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).IsRequired();
            builder.Property(u=>u.Name).IsRequired();
            builder.Property(u => u.Name).HasMaxLength(75);
            builder.Property(u => u.IsDeleted);
            builder.Property(u => u.IsActive);
            builder.ToTable("Universities");
        }
    }
}
