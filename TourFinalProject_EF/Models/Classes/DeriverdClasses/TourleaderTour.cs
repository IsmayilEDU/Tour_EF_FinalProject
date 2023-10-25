using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes.DeriverdClasses
{
    public class TourleaderTour : IId
    {
        #region Fields
        public int Id { get ; init ; }
        public int TourleaderId { get; set; }
        public int TourId { get; set; }

        #endregion

        #region Navigation properties
        public Tourleader Tourleader { get; set; }
        public Tour Tour { get; set; }
        #endregion
    }
}
