using Models.AssistantModels.Interfaces;
using Models.Entities.AbstractEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities.DerivedEntities
{
    public class Tourist : User, IId
    {
        #region Fields
        public int Id { get; init; }

        #endregion

        #region Navigation properties
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual BankCard bankCard { get; set; }
        #endregion
    }
}
