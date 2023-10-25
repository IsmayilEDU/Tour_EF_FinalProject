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
    internal class TourleaderTourConfiguration : IEntityTypeConfiguration<TourleaderTour>
    {
        public void Configure(EntityTypeBuilder<TourleaderTour> builder)
        {

            #region Configure fields
            //  Id
            builder.HasKey(tourleaderTour => tourleaderTour.Id);
            builder.Property(tourleaderTour => tourleaderTour.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Id of tourleader
            builder.Property(tourleaderTour => tourleaderTour.TourleaderId).HasColumnName("TourleaderId").HasColumnType("int").IsRequired();
            
            //  Id of tour
            builder.Property(tourleaderTour => tourleaderTour.TourId).HasColumnName("TourId").HasColumnType("int").IsRequired();
            
            #endregion

            #region Relations with other tables

            #endregion

        }
    }
}
