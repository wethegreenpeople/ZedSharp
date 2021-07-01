using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ZedSharp.Models
{
    public class HashInfo
    {
        [JsonPropertyName("color")]
        public string Color { get; set; }
        [JsonPropertyName("hex_code")]
        public string HexCode { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
