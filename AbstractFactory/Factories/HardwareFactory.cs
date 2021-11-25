using AbstractFactory.Products.Keyboards;
using AbstractFactory.Products.Microphones;
using AbstractFactory.Products.Mouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public abstract class HardwareFactory
    {
        public abstract IKeyboard CreateKeyboard(string serialCode);
        public abstract IMouse CreateMouse(int dpi);
        public abstract IMicrophone CreateMicrophone(string model);
    }
}
