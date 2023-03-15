using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SinhVien.Model.Configuration;
using SinhVien.Model.Entity;
using SinhVien.Model.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.FE
{
    public class SinhVienDbcontext :IdentityDbContext<User,Role,Guid>
    {
        public SinhVienDbcontext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // cofiguration using Fluent Api
            modelBuilder.ApplyConfiguration (new AppConfiguration());
            modelBuilder.ApplyConfiguration (new SinhVienConfiguration());
            modelBuilder.ApplyConfiguration (new LopConfiguration());
            modelBuilder.ApplyConfiguration(new KhoaConfiguration());
            modelBuilder.ApplyConfiguration(new GiangVienConfiguration());
            modelBuilder.ApplyConfiguration(new MonHocConfiguration());
            modelBuilder.ApplyConfiguration(new DiemThiConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRole").HasKey(x => new {x.UserId,x.RoleId});
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogin").HasKey(x=>x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserToken").HasKey(x=>x.UserId);
            ////Data setting 
            //modelBuilder.Seed();

            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Appconfig> Appconfig { get; set; }
        public DbSet<SinhVienET> SinhVienETs { get; set; }
        public DbSet<LopET> LopETs { get; set; }
        public DbSet<KhoaET> KhoaETs { get; set; }
        public DbSet<GiangVienET> giangVienETs { get; set; }
        public DbSet<MonHocET> MonHocETs { get; set; }
        public DbSet<DiemThiET> diemThiETs { get; set; }
        public DbSet<User>usErs { get; set; }
        public DbSet<Role>roLes { get; set; }
    }
}
