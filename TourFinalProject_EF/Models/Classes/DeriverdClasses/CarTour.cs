using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes.DeriverdClasses
{
    public class CarTour
    {
        #region Fields
        public int CarId { get; set; }
        public int TourId { get; set; }

        #endregion

        #region Navigation properties
        public virtual Car Car { get; set; }
        public virtual Tour Tour { get; set; }
        #endregion

    }
}
