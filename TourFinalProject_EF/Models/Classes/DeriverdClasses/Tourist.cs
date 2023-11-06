using Models.Classes.AbstractClasses;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes.DeriverdClasses
{
    public class Tourist : User, IId
    {
        #region Fields
        public int Id { get; init ; }

        #endregion

        #region Navigation properties
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual BankCard bankCard { get; set; }
        #endregion
    }
}
