using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Microphones
{
    public class DellMicrophone : IMicrophone
    {
        public string Model { get; set; }

        public DellMicrophone(string model)
            => Model = model;
    }
}
