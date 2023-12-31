﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities.DerivedEntities;

namespace Databases.Configurations
{
    internal class TourleaderConfiguration : IEntityTypeConfiguration<Tourleader>
    {
        public void Configure(EntityTypeBuilder<Tourleader> builder)
        {

            #region Configure fields
            //  Id
            builder.HasKey(tourleader => tourleader.Id);
            builder.Property(tourleader => tourleader.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Name
            builder.Property(tourleader => tourleader.Name).HasColumnName("Name").HasColumnType("nvarchar(20)").IsRequired();

            //  Surname
            builder.Property(tourleader => tourleader.Surname).HasColumnName("Surname").HasColumnType("nvarchar(20)").IsRequired();

            //  Phone
            builder.Property(tourleader => tourleader.Phone).HasColumnName("Phone").HasColumnType("nvarchar(20)").IsRequired();

            #endregion

            #region Relations with other tables

            #endregion

            #region Datas
            builder.HasData
                (
                new Tourleader() { Name = "Senan", Surname = "Kerimov", Phone = "099-777-77-77"},
                new Tourleader() { Name = "Ilkin", Surname = "Aslanov", Phone = "099-444-44-44"}
                );
            #endregion

        }
    }
}
