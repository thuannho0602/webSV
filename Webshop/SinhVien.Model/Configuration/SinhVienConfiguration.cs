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
    public class SinhVienConfiguration : IEntityTypeConfiguration<SinhVienET>
    {
        public void Configure(EntityTypeBuilder<SinhVienET> builder)
        {
            builder.ToTable("SinhVien");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Firstname).IsRequired().IsUnicode().HasMaxLength(50);
            builder.Property(x=>x.Lastname).IsRequired().IsUnicode().HasMaxLength(50);
            builder.Property(x => x.GioiTinh).IsRequired();
            builder.Property(x=>x.NgaySinh).IsRequired();


        }
    }
}
