using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class VatInvoiceCreator : InvoiceCreator
    {
        public override IInvoice CreateInvoice()
        {
            var invoice = new VatInvoice();
            invoice.VATValues = new List<int> { 8, 11, 23 };

            return invoice;
        }
    }
}
