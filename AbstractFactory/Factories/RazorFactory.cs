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
    public class RazorFactory : HardwareFactory
    {
        public override IKeyboard CreateKeyboard(string serialCode)
        {
            //Could be more complicated code... ;)
            return new RazorKeyboard();
        }

        public override IMicrophone CreateMicrophone(string model)
        {
            return new RazorMicrophone(model);
        }

        public override IMouse CreateMouse(int dpi)
        {
            return new RazorMouse();
        }
    }
}
