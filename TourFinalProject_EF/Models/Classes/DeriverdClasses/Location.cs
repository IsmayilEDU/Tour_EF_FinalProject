using Models.Interfaces;

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
        public virtual ICollection<TourLocation> TourLocations { get; set; }
        #endregion
    }
}
