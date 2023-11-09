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
    internal class TourConfiguration : IEntityTypeConfiguration<Tour>
    {
        public void Configure(EntityTypeBuilder<Tour> builder)
        {

            #region Configure fields
            //  Id
            builder.HasKey(tour => tour.Id);
            builder.Property(tour => tour.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  StartTime
            builder.Property(tour => tour.StartTime).HasColumnName("StartTime").HasColumnType("date").IsRequired();

            //  FinishTime
            builder.Property(tour => tour.FinishTime).HasColumnName("FinishTime").HasColumnType("date").IsRequired();

            //  Tourleader
            builder.Property(tour => tour.TourleaderId).HasColumnName("TourleaderId").HasColumnType("int").IsRequired();

            //  IsActive
            builder.Property(tour => tour.IsActive).HasColumnName("IsActive").HasColumnType("bit").IsRequired();
            #endregion

            #region Relations with other tables
            builder.HasOne(tour => tour.Tourleader).WithMany(tourleader => tourleader.Tours).HasForeignKey(tour => tour.TourleaderId);
            #endregion

            #region Datas
            builder.HasData
                (
                new Tour() {StartTime = DateOnly.FromDateTime(DateTime.Now), FinishTime = new DateOnly(2025,1,1), TourleaderId = 1, IsActive = true},
                new Tour() {StartTime = DateOnly.FromDateTime(DateTime.Now), FinishTime = new DateOnly(2024,1,1), TourleaderId = 2, IsActive = true}
                );
            #endregion

        }
    }
}
