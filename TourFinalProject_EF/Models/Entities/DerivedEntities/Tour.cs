using Models.AssistantModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.DerivedEntities
{
    public class Tour : IId
    {
        #region Fields

        //  Id
        public int Id { get; init; }

        //  StartTime
        public DateTime StartTime { get; set; }

        //  FinishTime
        public DateTime FinishTime { get; set; }

        //  TourleaderId
        public int TourleaderId { get; set; }

        //  IsActive
        public bool IsActive { get; set; }

        #endregion

        #region Navigation properties

        public virtual ICollection<CarTour> CarTours { get; set; }
        public virtual Tourleader Tourleader { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<TourLocation> TourLocations { get; set; }

        #endregion
    }
}
