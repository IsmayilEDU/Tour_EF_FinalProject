using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes.DeriverdClasses
{
    public class Ticket : IId
    {
        #region Fields
        public int Id { get ; init ; }

        public double Price { get; set; }

        public int? TourId { get; set; }

        public int? TouristId { get; set; }

        #endregion

        #region Navigation properties
        public virtual Tour? Tour { get; set; }
        public virtual Tourist? Tourist { get; set; }
        #endregion
    }
}
