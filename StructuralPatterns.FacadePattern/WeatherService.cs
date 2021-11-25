using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.FacadePattern
{
    public class WeatherService : IWeatherService
    {
        public double GetTempFarenheit(string latitude, string longitude)
        {
            return 70.3;
        }
    }
}
