using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8Library.Models
{
    public class Info
    {
        [JsonProperty("invoice")]
        public Invoice Invoice { get; set; }
    }
}
