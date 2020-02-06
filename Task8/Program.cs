using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task8Library;
using Task8Library.Models;

namespace Task8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Validation validation = new Validation();

            validation.GetInvoice();

            //validation.PrintShipments();

            Console.ReadKey();
        }
    }
}