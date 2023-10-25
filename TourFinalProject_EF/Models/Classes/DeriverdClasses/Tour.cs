using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes.DeriverdClasses
{
    public class Tour : IId
    {
        #region Fields
        //  Id
        public int Id { get ; init ; }


        #endregion

        #region Navigation properties
        public virtual ICollection<CarTour> CarTours { get; set; }
        public virtual ICollection<TourleaderTour> TourleaderTours { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

        #endregion
    }
}
