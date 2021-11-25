using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Microphones
{
    public class RazorMicrophone : IMicrophone
    {
        public string Model { get; set; }

        public RazorMicrophone(string model)
            => Model = model;
    }
}
