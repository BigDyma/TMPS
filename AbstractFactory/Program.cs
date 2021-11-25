using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jedyne miejsce aplikacji w którym musimy wywołać konkretną (a nie abstrakcyjną) fabrykę.
            var abstractFactoryClient = new AbstractFactoryClient();
            Console.WriteLine("Abstract client says: 'I need a set of Dell devices. Produce them for me!'");
            abstractFactoryClient.ProduceOneBundleOfHardware(new DellFactory());
            Console.WriteLine();

            Console.WriteLine("Abstract client says: 'I need another set, this time from Tracer'");
            abstractFactoryClient.ProduceOneBundleOfHardware(new TracerFactory());
            Console.WriteLine();

            Console.WriteLine("Abstract client says: 'Ok, now produce Razor's set and we are done!'");
            abstractFactoryClient.ProduceOneBundleOfHardware(new RazorFactory());

            Console.Read();
        }
    }
}
