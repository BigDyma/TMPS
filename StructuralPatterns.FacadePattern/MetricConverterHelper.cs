using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.FacadePattern
{
    public static class MetricConverterHelper
    {
        public static double FarenheitToCelcius(this double degrees)
        {
            return ((degrees - 32) / 9.0) * 5.0;
        }
    }
}
