using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.FE
{
    public class SinhVienDbContextFactory: IDesignTimeDbContextFactory<SinhVienDbcontext>
    {
        public SinhVienDbcontext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("QlSinhVien");

            var optionsBuilder = new DbContextOptionsBuilder<SinhVienDbcontext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new SinhVienDbcontext(optionsBuilder.Options);
        }
    }
}
