using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    public interface IInvoice
    {
        string Number { get; set; }
        string TaxpayerFullName { get; set; }
        string TaxpayerAddress { get; set; }
        string Title { get; }
    }
}
