using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task8Library.Models
{
    public class Shipment
    {
        [JsonProperty("shipmentid")]
        public string ShipmentId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("orders")]
        public List<Order> Orders { get; set; }

        public List<string> GetOrders()
        {
            List<string> list = new List<string>();

            foreach (var order in Orders)
            {
                list.Add(ShipmentId.ToString() + "\t" + Address.ToString() + "\t" + order);
            }

            return list;
        }

        public override string ToString()
        {
            foreach (var order in Orders)
            {
                return ShipmentId.ToString() + "\t" + Address.ToString() + "\t" + order;
            }

            return "";
        }
    }
}