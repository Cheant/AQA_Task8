using Newtonsoft.Json;

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
            return "Order ID: " + OrderId + "\t" + "Product Type: " + ProductType + "\t" + "Product Quantity: " + ProductQuantity;
        }
    }
}