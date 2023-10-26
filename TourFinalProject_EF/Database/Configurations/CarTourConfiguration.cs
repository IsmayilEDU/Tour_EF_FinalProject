﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Models.Classes.DeriverdClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            #endregion

        }
    }
}