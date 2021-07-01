using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ZedSharp.Models
{
    public class Horse
    {
        [JsonPropertyName("horse_id")]
        public int Id { get; set; }
        [JsonPropertyName("bloodline")]
        public string BloodLine { get; set; }
        [JsonPropertyName("breed_type")]
        public string BreedType { get; set; }
        [JsonPropertyName("genotype")]
        public string GenoType { get; set; }
        [JsonPropertyName("horse_type")]
        public string Type { get; set; }
        [JsonPropertyName("img_url")]
        public string ImageUrl { get; set; }
        [JsonPropertyName("number_of_races")]
        public int NumberOfRaces { get; set; }
        [JsonPropertyName("owner")]
        public string Owner { get; set; }
        [JsonPropertyName("super_coat")]
        public bool SuperCoat { get; set; }
        [JsonPropertyName("tx")]
        public string Tx { get; set; }
        [JsonPropertyName("tx_date")]
        public DateTime TxDate { get; set; }
        [JsonPropertyName("win_rate")]
        public float WinRate { get; set; }
        [JsonPropertyName("hash_info")]
        public HashInfo HashInfo { get; set; }
        [JsonPropertyName("career")]
        public CareerStats CareerStats { get; set; }
    }
}
