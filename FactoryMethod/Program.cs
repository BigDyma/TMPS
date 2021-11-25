using FactoryMethod.Creators;
using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IInvoice invoice;
            InvoiceCreator invCreator = new VatInvoiceCreator();
            invoice = invCreator.CreateInvoice();

            Console.WriteLine($": {invoice.Title}");

            invCreator = new AdvanceInvoiceCreator();
            invoice = invCreator.CreateInvoice();
            Console.WriteLine($": {invoice.Title}");

            Console.Read();
        }
    }
}
