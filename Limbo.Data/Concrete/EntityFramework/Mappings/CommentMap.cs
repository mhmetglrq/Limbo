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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.Id).ValueGeneratedOnAdd();
            builder.Property(c=>c.Text).IsRequired();
            builder.Property(c => c.Text).HasMaxLength(100);
            builder.Property(c=>c.Value).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.HasOne<Department>(c=>c.Department).WithMany(d=>d.Comment).HasForeignKey(c=>c.DepartmentId);
            builder.ToTable("Comment");
        }
    }
}
