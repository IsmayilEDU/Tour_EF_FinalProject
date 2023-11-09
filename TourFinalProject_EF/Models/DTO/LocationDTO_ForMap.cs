using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class LocationDTO_ForMap
    {
        public LocationDTO_ForMap(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        //  Uzunluq
        public double Longitude { get; set; }

        //  En
        public double Latitude { get; set; }
    }
}
