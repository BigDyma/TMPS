using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.FacadePattern
{
    public interface ITemperatureService
    {
        LocalTemperature GetTemperature(string zipCode);
    }
}
