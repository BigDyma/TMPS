using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.FacadePattern
{
    public interface IGeoLocationService
    {
        Coordinates GetCoordinatesForZipCode(string zipCode);
        string GetCityForZipCode(string zipCode);
        string GetStateForZipCode(string zipCode);
    }
}
