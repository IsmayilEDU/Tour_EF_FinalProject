using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Classes.DeriverdClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {

            #region Configure fields
            //  Id
            builder.HasKey(car => car.Id);
            builder.Property(car => car.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1,1).IsRequired();

            //  Brand
            builder.Property(car => car.Brand).HasColumnName("Brand").HasColumnType("nvarchar(20)").IsRequired();

            //  Model
            builder.Property(car => car.Model).HasColumnName("Model").HasColumnType("nvarchar(20)").IsRequired();

            //  Year
            builder.Property(car => car.Year).HasColumnName("Year").HasColumnType("int").IsRequired();

            //  Number of car
            builder.Property(car => car.CarNumber).HasColumnName("CarNumber").HasColumnType("nvarchar(20)").IsRequired();

            //  Count of seats
            builder.Property(car => car.SeatCount).HasColumnName("SeatCount").HasColumnType("int").IsRequired();



            #endregion

            #region Relations with other tables
            builder.HasOne(car => car.Driver).WithOne(driver => driver.Car).HasForeignKey<Driver>(driver => driver.CarId);
            #endregion

        }
    }
}
