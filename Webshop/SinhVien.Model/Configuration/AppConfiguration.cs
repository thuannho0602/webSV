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
    public  class AppConfiguration: IEntityTypeConfiguration<Appconfig>
    {
        public void Configure(EntityTypeBuilder<Appconfig> builder)
        {
            //builder.ToTable("AppConfigurations");
            //builder.HasKey(x=>x.);
            //builder.Property().
            builder.ToTable("AppConfigs");
            builder.HasKey(x => x.Key);
            builder.Property(x => x.Value).IsRequired(true);
        }
    }
}
