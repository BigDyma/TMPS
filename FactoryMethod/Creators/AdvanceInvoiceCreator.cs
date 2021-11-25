using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Products;

namespace FactoryMethod.Creators
{
    public class AdvanceInvoiceCreator : InvoiceCreator
    {
        public override IInvoice CreateInvoice()
        {
            var invoice = new AdvanceInvoice();
            invoice.AdvancedAmount = 100;

            return invoice;
        }
    }
}
