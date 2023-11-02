using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Models.Classes.DeriverdClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Configurations
{
    internal class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {

            #region Configure fields

            //  Id
            builder.HasKey(driver => driver.Id);
            builder.Property(driver => driver.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Name
            builder.Property(driver => driver.Name).HasColumnName("Name").HasColumnType("nvarchar(20)").IsRequired();
            
            //  Surname
            builder.Property(driver => driver.Surname).HasColumnName("Surname").HasColumnType("nvarchar(20)").IsRequired();

            //  Phone
            builder.Property(driver => driver.Phone).HasColumnName("Phone").HasColumnType("nvarchar(20)").IsRequired();

            //  Category of license of driver
            builder.Property(driver => driver.driverLicenseCategory).HasColumnName("driverLicenseCategory").HasColumnType("nvarchar(1)").IsRequired();

            //  CarId
            builder.Property(driver => driver.CarId).HasColumnName("CarId").HasColumnType("int").IsRequired();
            #endregion

            #region Relations with other tables

            #endregion

        }
    }
}
