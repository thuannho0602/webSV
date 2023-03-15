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
    public class GiangVienConfiguration:IEntityTypeConfiguration<GiangVienET>
    {
        public void Configure(EntityTypeBuilder<GiangVienET> builder)
        {
            builder.ToTable("GiangVien");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.TenGV)
                .HasMaxLength(50).
                IsRequired();
            builder.Property(x => x.ChuyenNganh)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(gv => gv.KhoaET)
                .WithMany(k => k.GiangVienETs)
                .HasForeignKey(gv => gv.KhoaId)
                .HasConstraintName("FK_GiangVien_Khoa");
        }
    }
}
