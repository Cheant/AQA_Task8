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