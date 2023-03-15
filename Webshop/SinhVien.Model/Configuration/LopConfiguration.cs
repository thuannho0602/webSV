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
    public class LopConfiguration:IEntityTypeConfiguration<LopET>
    {
        public void Configure(EntityTypeBuilder<LopET> builder)
        {
            builder.ToTable("Lop");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TenLop)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasOne(k => k.KhoaET)
                .WithMany(l => l.LopETs)
                .HasForeignKey(fk => fk.KhoaId)
                .HasConstraintName("FK_Lop_Khoa");


        }
    }
}
