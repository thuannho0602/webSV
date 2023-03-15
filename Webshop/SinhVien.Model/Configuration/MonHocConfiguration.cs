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
    public class MonHocConfiguration:IEntityTypeConfiguration<MonHocET>
    {
        public void Configure(EntityTypeBuilder<MonHocET> builder)
        {
            builder.ToTable("MonHoc");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TenMH).HasMaxLength(50).IsRequired();
            builder.Property(x=>x.SoTiet).IsRequired();
        }
    }
}
