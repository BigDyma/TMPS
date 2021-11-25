using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AbstractFactoryClient
    {
        public void ProduceOneBundleOfHardware(HardwareFactory factory)
        {
            string serialNumber = DateTime.Now.Ticks.ToString(); //Dla uproszczenia - losowa liczba.
            var keyboard = factory.CreateKeyboard(serialNumber);
            var mouse = factory.CreateMouse(4000);
            var microfon = factory.CreateMicrophone("abc");

            keyboard.PrintSerialNumber();
            Console.WriteLine($"Mouse with {mouse.GetDPI()} DPI");
            Console.WriteLine($"Mic (model {microfon.Model})");
        }
    }
}
