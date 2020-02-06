using System.Collections.Generic;
using Newtonsoft.Json;

namespace Task8Library.Models
{
    public class Invoice
    {
        [JsonProperty("shipments")]
        public List<Shipment> Shipments { get; set; }
    }
}