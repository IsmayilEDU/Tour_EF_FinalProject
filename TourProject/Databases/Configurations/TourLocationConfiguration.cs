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
    internal class TourLocationConfiguration : IEntityTypeConfiguration<TourLocation>
    {
        public void Configure(EntityTypeBuilder<TourLocation> builder)
        {
            #region Fields

            //  Id
            builder.HasKey(tourLocation => tourLocation.Id);
            builder.Property(tourLocation => tourLocation.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  TourId
            builder.Property(tourLocation => tourLocation.TourId).HasColumnName("TourId").HasColumnType("int").IsRequired();

            //  LocationId
            builder.Property(tourLocation => tourLocation.LocationId).HasColumnName("LocationId").HasColumnType("int").IsRequired();

            #endregion

            #region Relations other tables
            builder.HasOne(tourLocation => tourLocation.Tour).WithMany(tour => tour.TourLocations).HasForeignKey(tourLocation => tourLocation.TourId);
            builder.HasOne(tourLocation => tourLocation.Location).WithMany(tour => tour.TourLocations).HasForeignKey(tourLocation => tourLocation.LocationId);
            #endregion

            #region Datas
            builder.HasData
                (
                new TourLocation() { TourId = 1, LocationId = 1},
                new TourLocation() { TourId = 1, LocationId = 2},
                new TourLocation() { TourId = 1, LocationId = 3},
                new TourLocation() { TourId = 1, LocationId = 4},
                new TourLocation() { TourId = 1, LocationId = 5},
                new TourLocation() { TourId = 2, LocationId = 6},
                new TourLocation() { TourId = 2, LocationId = 7},
                new TourLocation() { TourId = 2, LocationId = 8},
                new TourLocation() { TourId = 2, LocationId = 9},
                new TourLocation() { TourId = 2, LocationId = 10}
                );
            #endregion
        }
    }
}
