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
    public class DellFactory : HardwareFactory
    {
        private List<DellKeyboard> KeyboardsCache;
        private List<DellMouse> MousesCache;

        public DellFactory()
        {
            KeyboardsCache = new List<DellKeyboard>();
            MousesCache = new List<DellMouse>();
        }

        public override IKeyboard CreateKeyboard(string serialCode)
        {
            var keyboardFromCache = KeyboardsCache.FirstOrDefault(c => c.SerialCode == serialCode);
            if (keyboardFromCache != null)
            {
                return keyboardFromCache;
            }
            else
            {
                var keyboardToAdd = new DellKeyboard(serialCode);
                KeyboardsCache.Add(keyboardToAdd);
                return keyboardToAdd;
            }
        }

        public override IMicrophone CreateMicrophone(string model)
        {
            return new DellMicrophone(model);
        }

        public override IMouse CreateMouse(int dpi)
        {
            var mouseFromCache = MousesCache.FirstOrDefault(c => c.DPI == dpi);
            if (mouseFromCache != null)
            {
                return mouseFromCache;
            }
            else
            {
                var mouseToAdd = new DellMouse(dpi, 45);
                MousesCache.Add(mouseToAdd);
                return mouseToAdd;
            }
        }
    }
}
