using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities.DerivedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases.Configurations
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
            builder.Property(car => car.CarNumber).HasColumnName("CarNumber").HasColumnType("nvarchar(20)").IsUnicode().IsRequired();

            //  Count of seats
            builder.Property(car => car.SeatCount).HasColumnName("SeatCount").HasColumnType("int").IsRequired();

            #endregion

            #region Relations with other tables
            builder.HasOne(car => car.Driver).WithOne(driver => driver.Car).HasForeignKey<Driver>(driver => driver.CarId);
            #endregion

            #region Datas
            builder.HasData
                (
                new Car
                {
                    Brand = "Kia", Model= "Rio", Year = 2012,
                    CarNumber = "77-AB-777", SeatCount = 25
                },
                new Car
                {
                    Brand = "Hyundai", Model= "Sonata", Year = 2015,
                    CarNumber = "10-OO-222", SeatCount = 25
                },
                new Car
                {
                    Brand = "Khazar", Model= "LD", Year = 2019,
                    CarNumber = "11-AA-444", SeatCount = 25
                },
                new Car
                {
                    Brand = "Lada", Model= "Priora", Year = 2015,
                    CarNumber = "44-AA-444", SeatCount = 25
                },
                new Car
                {
                    Brand = "Mercedes", Model= "C200", Year = 2010,
                    CarNumber = "55-BB-555", SeatCount = 25
                },
                new Car
                {
                    Brand = "BMW", Model= "X6", Year = 2012,
                    CarNumber = "88-BB-888", SeatCount = 25
                },
                new Car
                {
                    Brand = "Audi", Model= "TT", Year = 2017,
                    CarNumber = "30-OO-003", SeatCount = 25
                },
                new Car
                {
                    Brand = "Kia", Model= "Sportage", Year = 2015,
                    CarNumber = "77-AA-777", SeatCount = 25
                },
                new Car
                {
                    Brand = "Toyota", Model= "Corolla", Year = 2013,
                    CarNumber = "22-GG-222", SeatCount = 25
                },
                new Car
                {
                    Brand = "Ford", Model= "Fusion", Year = 2018,
                    CarNumber = "43-TL-043", SeatCount = 25
                }

                );
            #endregion

        }
    }
}
