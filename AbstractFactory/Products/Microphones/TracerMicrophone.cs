using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Microphones
{
    public class TracerMicrophone : IMicrophone
    {
        public string Model { get; set; }

        public TracerMicrophone(string model)
            => Model = model + "_2018";
    }
}
