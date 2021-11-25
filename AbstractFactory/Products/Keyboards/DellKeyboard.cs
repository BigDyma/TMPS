using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Keyboards
{
    public class DellKeyboard : IKeyboard
    {
        public string SerialCode { get; set; }
        public decimal Price { get; set; }

        public DellKeyboard(string serialCode)
            => SerialCode = serialCode;

        public void PrintSerialNumber()
            => Console.WriteLine($"Dell keyboard with serial: {SerialCode}");
    }
}
