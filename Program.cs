using System;

namespace InvoiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("rice" , "dangote rice",5,500);
            Console.WriteLine(invoice.GetInvoiceAmount());
        }
    }
}
