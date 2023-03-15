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
    public class DiemThiConfiguration:IEntityTypeConfiguration<DiemThiET>
    {
        public void Configure(EntityTypeBuilder<DiemThiET> builder)
        {
            builder.ToTable("DiemThi");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.LanThi).IsRequired();
            builder.Property(x => x.DiemThi).IsRequired();
        }
    }
}
