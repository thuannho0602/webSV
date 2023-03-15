using Microsoft.EntityFrameworkCore;
using SinhVien.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Extensions
{
    public static class ModeluilBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appconfig>().HasData(
                new Appconfig() { Key="Hometile",Value="pham vien chieu,phuong 14,GV,TPHCM"},
                new Appconfig() { Key = "Homefdd", Value = "Phan huy ich,phuong 8,GV,TPHCM" },
                new Appconfig() { Key = "Homesssss", Value = "Quang trung,phuong 10,GV,TPHCM" }
                );
            
            }
        }
    }

