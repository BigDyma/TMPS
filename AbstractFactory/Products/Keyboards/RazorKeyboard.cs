using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Keyboards
{
    public class RazorKeyboard : IKeyboard
    {
        public string SerialCode { get; set; }
        public decimal Price { get; set; }

        public void PrintSerialNumber()
            => Console.WriteLine($"Razer keyboard with serial: {SerialCode}");
    }
}
