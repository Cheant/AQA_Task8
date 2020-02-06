using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task8Library.Models;
using Newtonsoft.Json.Linq;

namespace Task8Library
{
    public class Validation
    {
        private string path = @"D:\Task8.json";


        public Invoice GetInvoice()
        {
            //string jsonText = File.ReadAllText(path);

            string jsonText = JObject.Parse(File.ReadAllText(path)).SelectToken("invoice").ToString();

            Invoice invoice = JsonConvert.DeserializeObject<Invoice>(jsonText);

            //string text2 = JsonConvert.SerializeObject(invoice);

            foreach (var shipment in invoice.Shipment)
            {
                Console.WriteLine(shipment);
            }

            return invoice;
        }

        //public void PrintShipments()
        //{
        //    foreach (var shipment in Shipments)
        //    {
        //        Console.WriteLine(shipment);
        //    }
        //}

    }
}