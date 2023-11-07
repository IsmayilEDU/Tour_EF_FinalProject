using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using Models.Entities.DerivedEntities;

namespace Database.Configurations
{
    internal class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {

            #region Configure fields
            //  Id
            builder.HasKey(ticket => ticket.Id);
            builder.Property(ticket => ticket.Id).HasColumnName("Id").HasColumnType("int").UseIdentityColumn(1, 1).IsRequired();

            //  Price
            builder.Property(ticket => ticket.Price).HasColumnName("Price").HasColumnType("decimal(13,5)").IsRequired();

            //  Id of tour
            builder.Property(ticket => ticket.TourId).HasColumnName("TourId").HasColumnType("int");
            
            //  Id of tourist
            builder.Property(ticket => ticket.TouristId).HasColumnName("TouristId").HasColumnType("int");
            #endregion

            #region Relations with other tables
            builder.HasOne(ticket => ticket.Tour).WithMany(tour => tour.Tickets).HasForeignKey(ticket => ticket.TourId);
            builder.HasOne(ticket => ticket.Tourist).WithMany(tourist => tourist.Tickets).HasForeignKey(ticket => ticket.TouristId);
            #endregion

        }
    }
}
