using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Mouses
{
    public class DellMouse : IMouse
    {
        public int DPI { get; set; }
        public decimal Price { get; set; }

        public DellMouse(int dpi, decimal price)
        {
            DPI = dpi;
            Price = price;
        }

        public int GetDPI()
        {
            Console.WriteLine("Call from method returning Dell's mouse DPI");
            return DPI;
        }
    }
}
