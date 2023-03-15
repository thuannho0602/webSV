using Microsoft.EntityFrameworkCore;
using SinhVien.Model.Configuration;
using SinhVien.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.FE
{
    public class SinhVienDbcontext : DbContext
    {
        public SinhVienDbcontext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration (new AppConfiguration());
            modelBuilder.ApplyConfiguration (new SinhVienConfiguration());
            modelBuilder.ApplyConfiguration (new LopConfiguration());
            modelBuilder.ApplyConfiguration(new KhoaConfiguration());
            modelBuilder.ApplyConfiguration(new GiangVienConfiguration());
            modelBuilder.ApplyConfiguration(new MonHocConfiguration());
            modelBuilder.ApplyConfiguration(new DiemThiConfiguration());

            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Appconfig> Appconfigs { get; set; }
        public DbSet<SinhVienET> SinhVienETs { get; set; }
        public DbSet<LopET> LopETs { get; set; }
        public DbSet<KhoaET> KhoaETs { get; set; }
        public DbSet<GiangVienET> giangVienETs { get; set; }
        public DbSet<MonHocET> MonHocETs { get; set; }
        public DbSet<DiemThiET> diemThiETs { get; set; }
    }
}
