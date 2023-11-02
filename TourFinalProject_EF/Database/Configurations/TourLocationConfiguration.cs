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
        }
    }
}
