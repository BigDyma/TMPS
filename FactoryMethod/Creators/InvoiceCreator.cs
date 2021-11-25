using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creators
{
    public abstract class InvoiceCreator
    {
        public abstract IInvoice CreateInvoice(); 

        public IInvoice CreateInvoice(InvoiceType invType) 
        {
            switch(invType)
            {
                case InvoiceType.AdvanceInvoice:
                    return new AdvanceInvoiceCreator().CreateInvoice();
                case InvoiceType.VATInvoice:
                    return new VatInvoiceCreator().CreateInvoice();
                default: return null;
            }
        }
    }
}
