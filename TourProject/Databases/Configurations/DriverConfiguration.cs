using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities.DerivedEntities;
using Models.AssistantModels.Enums;

namespace Databases.Configurations
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
            builder.Property(driver => driver.driverLicenseCategory).HasColumnName("driverLicenseCategory").HasColumnType("int").IsRequired();

            //  CarId
            builder.Property(driver => driver.CarId).HasColumnName("CarId").HasColumnType("int").IsRequired();
            #endregion

            #region Relations with other tables
            builder.HasOne(driver => driver.Car).WithOne(car => car.Driver).HasForeignKey<Driver>(driver => driver.CarId);
            #endregion

            #region Datas
            builder.HasData
                (
                new Driver()
                {
                    Name = "Ismayil", Surname = "Kerimzade", Phone = "099-777-77-77", driverLicenseCategory = DriverLicenseCategory.B, CarId = 1
                },
                new Driver()
                {
                    Name = "Huseyn", Surname = "Senanov", Phone = "055-555-55-55", driverLicenseCategory = DriverLicenseCategory.B, CarId = 2
                },
                new Driver()
                {
                    Name = "Kerim", Surname = "Huseynli", Phone = "099-888-88-88", driverLicenseCategory = DriverLicenseCategory.B, CarId = 3
                },
                new Driver()
                {
                    Name = "Orxan", Surname = "Mustafazade", Phone = "077-777-77-77", driverLicenseCategory = DriverLicenseCategory.B, CarId = 4
                },
                new Driver()
                {
                    Name = "Shain", Surname = "Veliyev", Phone = "010-111-11-11", driverLicenseCategory = DriverLicenseCategory.B, CarId = 5
                },
                new Driver()
                {
                    Name = "Royyal", Surname = "Kerimov", Phone = "055-666-66-66", driverLicenseCategory = DriverLicenseCategory.C, CarId = 6
                },
                new Driver()
                {
                    Name = "Samir", Surname = "Emirov", Phone = "099-999-99-99", driverLicenseCategory = DriverLicenseCategory.C, CarId = 7
                },
                new Driver()
                {
                    Name = "Elamr", Surname = "Babayev", Phone = "077-444-44-44", driverLicenseCategory = DriverLicenseCategory.C, CarId = 8
                },
                new Driver()
                {
                    Name = "Mahir", Surname = "Ahmadov", Phone = "010-444-44-44", driverLicenseCategory = DriverLicenseCategory.C, CarId = 9
                },
                new Driver()
                {
                    Name = "Perviz", Surname = "Muradov", Phone = "099-333-33-33", driverLicenseCategory = DriverLicenseCategory.C, CarId = 10
                }
                );
            #endregion

        }
    }
}
