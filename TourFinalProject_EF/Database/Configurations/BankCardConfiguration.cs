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
    internal class BankCardConfiguration : IEntityTypeConfiguration<BankCard>
    {
        public void Configure(EntityTypeBuilder<BankCard> builder)
        {

            #region Configure fields
            //  Id
            builder.HasKey(bankcard => bankcard.Id);
            builder.Property(bankcard => bankcard.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  BankName
            builder.Property(bankcard => bankcard.BankName).HasColumnName("BankName").HasColumnType("nvarchar(20)").IsRequired();

            //  CardNumber
            builder.Property(bankcard => bankcard.CardNumber).HasColumnName("CardNumber").HasColumnType("nvarchar(20)").IsRequired();

            //  ExpirationDate
            builder.Property(bankcard => bankcard.ExpirationDate).HasColumnName("ExpirationDate").HasColumnType("datetime2").IsRequired();

            //  CVC
            builder.Property(bankcard => bankcard.CVC).HasColumnName("CVC").HasColumnType("nvarchar(3)").IsRequired();

            //  Balance
            builder.Property(bankcard => bankcard.Balance).HasColumnName("Balance").HasColumnType("decimal(13,5)").IsRequired();

            //  TouristId
            builder.Property(bankcard => bankcard.TouristId).HasColumnName("TouristId").HasColumnType("int").IsRequired();

            #endregion

            #region Relations with other tables
            builder.HasOne(bankcard => bankcard.tourist).WithOne(tourist => tourist.bankCard).HasForeignKey<BankCard>(bankcard => bankcard.TouristId);
            #endregion

        }
    }
}
