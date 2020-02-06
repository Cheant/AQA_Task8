using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Task8Library.Models
{
    public class Order
    {
        [JsonProperty("orderid")]
        public string OrderId { get; set; }

        [JsonProperty("producttype")]
        public string ProductType { get; set; }

        [JsonProperty("productquantity")]
        public string ProductQuantity { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        public override string ToString()
        {
            return OrderId + "\t" + ProductType.ToString() + "\t" + ProductQuantity.ToString();
        }
    }
}