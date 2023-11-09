using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities.DerivedEntities;

namespace Database.Configurations
{
    internal class CarTourConfiguration : IEntityTypeConfiguration<CarTour>
    {
        public void Configure(EntityTypeBuilder<CarTour> builder)
        {

            #region Configure fields
            //  Id
            builder.HasKey(cartour => cartour.Id);
            builder.Property(cartour => cartour.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Id of car
            builder.Property(cartour => cartour.CarId).HasColumnName("CarId").HasColumnType("int").IsRequired();

            //  Id of tour
            builder.Property(cartour => cartour.TourId).HasColumnName("TourId").HasColumnType("int").IsRequired();
            #endregion

            #region Relations with other tables
            builder.HasOne(cartour => cartour.Car).WithMany(car => car.CarTours).HasForeignKey(cartour => cartour.CarId);
            builder.HasOne(cartour => cartour.Tour).WithMany(tour => tour.CarTours).HasForeignKey(cartour => cartour.TourId);
            #endregion

            #region Datas
            builder.HasData
                (
                new CarTour()
                {
                    CarId = 1, TourId = 1
                },
                new CarTour()
                {
                    CarId = 2, TourId = 1
                },
                new CarTour()
                {
                    CarId = 3, TourId = 1
                },
                new CarTour()
                {
                    CarId = 4, TourId = 1
                },
                new CarTour()
                {
                    CarId = 5, TourId = 1
                },
                new CarTour()
                {
                    CarId = 6, TourId = 2
                },
                new CarTour()
                {
                    CarId = 7, TourId = 2
                },
                new CarTour()
                {
                    CarId = 8, TourId = 2
                },
                new CarTour()
                {
                    CarId = 9, TourId = 2
                },
                new CarTour()
                {
                    CarId = 10,TourId = 2
                }
                );
            #endregion

        }
    }
}
