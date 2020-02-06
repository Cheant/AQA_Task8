using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task8Library.Models
{
    public class Customer
    {
        [JsonProperty("customerid")]
        public string CustomerId { get; set; }

        [JsonProperty("customername")]
        public string Name { get; set; }
    }
}