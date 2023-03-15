using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SinhVien.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Firstname)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Lastname)
               .HasMaxLength(50)
               .IsRequired();
            
            builder.Property(x => x.Email)
               .HasMaxLength(50)
               .IsUnicode()
               .IsRequired();

        }

    }
}
