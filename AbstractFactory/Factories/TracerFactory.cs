using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Products.Keyboards;
using AbstractFactory.Products.Microphones;
using AbstractFactory.Products.Mouses;

namespace AbstractFactory.Factories
{
    public class TracerFactory : HardwareFactory
    {
        public override IKeyboard CreateKeyboard(string serialCode)
        {
            //Could be more complicated code here... ;)
            return new TracerKeyboard();
        }

        public override IMicrophone CreateMicrophone(string model)
        {
            return new TracerMicrophone(model);
        }

        public override IMouse CreateMouse(int dpi)
        {
            return new TracerMouse();
        }
    }
}
