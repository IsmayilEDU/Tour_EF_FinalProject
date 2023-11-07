using Models.AssistantModels.Enums;
using Models.AssistantModels.Interfaces;
using Models.Entities.AbstractEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.DerivedEntities
{
    public class Driver : Human, IId
    {
        #region Fields
        public int Id { get; init; }

        public DriverLicenseCategory driverLicenseCategory { get; set; }

        public int CarId { get; set; }

        #endregion

        #region Navigation properties
        public virtual Car Car { get; set; }
        #endregion
    }
}
