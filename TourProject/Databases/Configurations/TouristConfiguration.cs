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
    internal class TouristConfiguration : IEntityTypeConfiguration<Tourist>
    {
        public void Configure(EntityTypeBuilder<Tourist> builder)
        {

            #region Configure fields
            //  Id
            builder.HasKey(tourist => tourist.Id);
            builder.Property(tourist => tourist.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Username
            builder.Property(tourist => tourist.Username).HasColumnName("Username").HasColumnType("nvarchar(20)").IsRequired();

            //  Password
            builder.Property(tourist => tourist.Password).HasColumnName("Password").HasColumnType("nvarchar(20)").IsRequired();

            //  Name
            builder.Property(tourist => tourist.Name).HasColumnName("Name").HasColumnType("nvarchar(20)").IsRequired();

            //  Surname
            builder.Property(tourist => tourist.Surname).HasColumnName("Surname").HasColumnType("nvarchar(20)").IsRequired();

            //  Phone
            builder.Property(tourist => tourist.Phone).HasColumnName("Phone").HasColumnType("nvarchar(20)").IsRequired();

            #endregion

            #region Relations with other tables
            builder.HasOne(tourist => tourist.bankCard).WithOne(bankCard => bankCard.tourist).HasForeignKey<BankCard>(bankcard => bankcard.TouristId);
            #endregion

            #region Datas
            builder.HasData
                (
                new Tourist()
                {
                    Username = "ismayil123", Password = "ismayil123", Name = "Ismayil", Surname = "Kerimzade", Phone = "010-210-00-10"
                },
                new Tourist()
                {
                    Username = "cavid123", Password = "cavid123", Name = "Cavid", Surname = "Atamoghlanov", Phone = "055-555-55-55"
                }
                );
            #endregion
        }
    }
}
