using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes.DeriverdClasses
{
    public class Location : IId
    {
        #region Fields

        //  Id
        public int Id { get ; init ; }

        //  Name
        public string Name { get; set; }

        //  Uzunluq
        public double Longitude { get; set; }

        //  En
        public double Latitude { get; set; }

        #endregion

        #region Navigation properties
        #endregion
    }
}
