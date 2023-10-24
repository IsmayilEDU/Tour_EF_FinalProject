using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes.DeriverdClasses
{
    public class TourleaderTour
    {
        #region Fields
        public int TourleaderId { get; set; }
        public int TourId { get; set; }
        #endregion

        #region Navigation properties
        public Tourleader Tourleader { get; set; }
        public Tour Tour { get; set; }
        #endregion
    }
}
