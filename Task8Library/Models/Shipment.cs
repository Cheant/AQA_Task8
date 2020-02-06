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

        [JsonProperty("order")]
        public List<Order> Order { get; set; }

        public override string ToString()
        {
            foreach (var order in Order)
            {
                return ShipmentId.ToString() + "\t" + Address.ToString() + order;
            }

            return ShipmentId.ToString() + "\t" + Address.ToString();
        }
    }
}