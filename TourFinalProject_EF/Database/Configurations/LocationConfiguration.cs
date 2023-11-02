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
        }
    }
}
