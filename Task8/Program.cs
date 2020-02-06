using System;
using Task8Library;

namespace Task8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Validation validation = new Validation();

            validation.PrintShipments();
            Console.ReadKey();
        }
    }
}