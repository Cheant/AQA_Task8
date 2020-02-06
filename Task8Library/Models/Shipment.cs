using System;
using System.Collections.Generic;
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

        public override string ToString()
        {
            return "Shipment ID: " + ShipmentId + "\t" + "Address: " + Address + Environment.NewLine;
        }
    }
}