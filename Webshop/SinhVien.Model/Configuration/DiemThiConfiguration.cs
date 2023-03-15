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
            builder.HasKey(dt => new {dt.MaSVId,dt.MaMHId});

            builder.HasOne(dt => dt.SinhVienET)
                .WithMany(sv => sv.DiemThiETs)
                .HasForeignKey(dt => dt.MaSVId)
                .HasConstraintName("FK_DiemThi-SinhVien");

            builder.HasOne(dt => dt.MonHocET)
                .WithMany(mh => mh.DiemThiETs)
                .HasForeignKey(dt => dt.MaMHId)
                .HasConstraintName("FK_DiemThi-MonHoc");
        }
    }
}
