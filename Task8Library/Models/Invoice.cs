﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8Library.Models
{
    public class Invoice
    {
        [JsonProperty("shipments")]
        public List<Shipment> Shipments { get; set; }
    }    
}
