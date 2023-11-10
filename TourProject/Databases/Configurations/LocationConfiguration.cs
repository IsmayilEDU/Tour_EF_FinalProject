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
    internal class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            #region Fields
            //  Id
            builder.HasKey(location => location.Id);
            builder.Property(location => location.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Name
            builder.Property(location => location.Name).HasColumnName("Name").HasColumnType("nvarchar(50)").IsRequired();

            //  Longitude
            builder.Property(location => location.Longitude).HasColumnName("Longitude").HasColumnType("decimal(7,3)");

            //  Latitude
            builder.Property(location => location.Latitude).HasColumnName("Longitude").HasColumnType("decimal(7,3)");
            #endregion

            #region Relations other tables

            #endregion

            #region Datas
            builder.HasData
                (
                new Location() { Name = "Baku", Longitude = 40.4093, Latitude = 49.8671 },
                new Location() { Name = "Sumgait", Longitude = 40.5855, Latitude = 49.6317 },
                new Location() { Name = "Ganja", Longitude = 40.6879, Latitude = 46.3723 },
                new Location() { Name = "Balakan", Longitude = 41.7038, Latitude = 46.4044 },
                new Location() { Name = "Qakh", Longitude = 41.4207, Latitude = 46.9320 },
                new Location() { Name = "Shusha", Longitude = 39.7537, Latitude = 46.7465 },
                new Location() { Name = "Khankendi", Longitude = 39.8265, Latitude = 46.7656 },
                new Location() { Name = "Sabirabad", Longitude = 39.9871, Latitude = 48.4693 },
                new Location() { Name = "Lerik", Longitude = 38.7736, Latitude = 48.4151 },
                new Location() { Name = "Qabala", Longitude = 40.9982, Latitude = 47.8700 }
                );
            #endregion
        }
    }
}
