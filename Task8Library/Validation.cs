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

            string jsonText2 = File.ReadAllText(path);
            Info invoice2 = JsonConvert.DeserializeObject<Info>(jsonText2);

            string jsonText = JObject.Parse(File.ReadAllText(path)).SelectToken("invoice").ToString();

            Invoice invoice = JsonConvert.DeserializeObject<Invoice>(jsonText);

            //string text2 = JsonConvert.SerializeObject(invoice);

            foreach (var shipment in invoice.Shipments)
            {
                Console.WriteLine(shipment.ToString());
                foreach(var order in shipment.Orders)
                {
                    Console.WriteLine(order.ToString());
                    Console.WriteLine(order.OrderId);
                    Console.WriteLine(order.Customer.Name);
                }
                
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