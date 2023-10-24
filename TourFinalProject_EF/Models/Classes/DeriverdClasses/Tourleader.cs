using Models.AsisstantClasses;
using Models.Classes.AbstractClasses;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes.DeriverdClasses
{
    public class Tourleader : Human, IId
    {
        #region Fields

        //  Id
        public int Id { get; init; }

        #endregion

        #region Navigation properties
        public ICollection<TourleaderTour> TourleaderTours { get; set; }
        #endregion
    }
}
