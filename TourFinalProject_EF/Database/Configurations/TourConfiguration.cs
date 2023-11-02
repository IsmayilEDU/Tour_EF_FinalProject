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
    internal class TourConfiguration : IEntityTypeConfiguration<Tour>
    {
        public void Configure(EntityTypeBuilder<Tour> builder)
        {

            #region Configure fields
            //  Id
            builder.HasKey(tour => tour.Id);
            builder.Property(tour => tour.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  StartTime
            builder.Property(tour => tour.StartTime).HasColumnName("StartTime").HasColumnType("datetime2").IsRequired();

            //  FinishTime
            builder.Property(tour => tour.FinishTime).HasColumnName("FinishTime").HasColumnType("datetime2").IsRequired();

            //  Tourleader
            builder.Property(tour => tour.TourleaderId).HasColumnName("TourleaderId").HasColumnType("int").IsRequired();
            #endregion

            #region Relations with other tables
            builder.HasOne(tour => tour.Tourleader).WithMany(tourleader => tourleader.Tours).HasForeignKey(tour => tour.TourleaderId);
            #endregion

        }
    }
    {
    }
}
