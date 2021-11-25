using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.FacadePattern
{
    public class GeoLocationService : IGeoLocationService
    {
        public Coordinates GetCoordinatesForZipCode(string zipCode)
        {
            return new Coordinates() { Latitude = "41°10'N", Longitude = "29°10'E" };
        }

        public string GetCityForZipCode(string zipCode)
        {
            return "Istanbul";
        }

        public string GetStateForZipCode(string zipCode)
        {
            return "Turkey";
        }
    }
}
