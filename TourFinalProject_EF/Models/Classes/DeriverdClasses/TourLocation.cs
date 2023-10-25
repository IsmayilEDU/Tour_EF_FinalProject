using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes.DeriverdClasses
{
    internal class TourLocation : IId
    {

        #region Fields
        public int Id { get ; init ; }

        public int TourId { get; set; }

        public int LocationId { get; set; }

        #endregion

        #region Navigation properties
        public virtual Tour Tour { get; set; }
        public virtual Location Location { get; set; }
        #endregion
    }
}
