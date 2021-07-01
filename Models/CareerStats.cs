using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ZedSharp.Models
{
    public class CareerStats
    {
        [JsonPropertyName("first")]
        public int FirstPlaceWins { get; set; }
        [JsonPropertyName("second")]
        public int SecondPlaceWins { get; set; }
        [JsonPropertyName("third")]
        public int ThirdPlaceWins { get; set; }
    }
}
