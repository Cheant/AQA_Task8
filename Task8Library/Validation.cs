using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Task8Library.Models;

namespace Task8Library
{
    public class Validation
    {
        private string path = @"D:\Task8.json";

        public void PrintShipments()
        {
            string jsonText = JObject.Parse(File.ReadAllText(path)).SelectToken("invoice").ToString();
            Invoice invoice = JsonConvert.DeserializeObject<Invoice>(jsonText);

            if (EnumHelper.RequestForEnumValue<YesNo>() == YesNo.Yes)
            {
                foreach (var shipment in invoice.Shipments)
                {
                    Console.WriteLine(Environment.NewLine + shipment.ToString());
                    Console.WriteLine("Orders:");

                    foreach (var order in shipment.Orders)
                    {
                        Console.WriteLine(order.ToString());
                        Console.WriteLine("Customer ID: " + order.Customer.CustomerId + "\t" + "Customer Name: " + order.Customer.Name);
                    }
                }
            }
            else
            {
                foreach (var shipment in invoice.Shipments)
                {
                    Console.WriteLine(Environment.NewLine + shipment.ToString());
                }
            }
        }
    }
}