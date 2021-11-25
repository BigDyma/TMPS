using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Mouses
{
    public interface IMouse
    {
        int DPI{ get; set; }
        decimal Price { get; set; }
        int GetDPI();
    }
}
