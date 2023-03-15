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
    public class KhoaConfiguration:IEntityTypeConfiguration<KhoaET>
    {
        public void Configure(EntityTypeBuilder<KhoaET> builder)
        {
            builder.ToTable("Khoa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TenKhoa).HasMaxLength(50).IsRequired();


        }
    }
}
