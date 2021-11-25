using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.FacadePattern
{
  public  interface IWeatherService
  {
      double GetTempFarenheit(string latitude, string longitude);
  }
}
