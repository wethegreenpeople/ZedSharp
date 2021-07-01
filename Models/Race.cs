using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ZedSharp.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class RaceHorse
    {
        [JsonPropertyName("final_position")]
        public string FinalPosition { get; set; }

        [JsonPropertyName("finish_time")]
        public double FinishTime { get; set; }

        [JsonPropertyName("gate")]
        public string Gate { get; set; }

        [JsonPropertyName("gen")]
        public string Gen { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("hex_color")]
        public string HexColor { get; set; }

        [JsonPropertyName("horse_id")]
        public int HorseId { get; set; }

        [JsonPropertyName("img_url")]
        public string ImgUrl { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("owner_address")]
        public string OwnerAddress { get; set; }

        [JsonPropertyName("races")]
        public object Races { get; set; }

        [JsonPropertyName("stable_name")]
        public string StableName { get; set; }

        [JsonPropertyName("win_rate")]
        public object WinRate { get; set; }
    }

    public class PrizePool
    {
        [JsonPropertyName("first")]
        public string First { get; set; }

        [JsonPropertyName("second")]
        public string Second { get; set; }

        [JsonPropertyName("third")]
        public string Third { get; set; }

        [JsonPropertyName("total")]
        public string Total { get; set; }
    }

    public class Race
    {
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("class")]
        public int Class { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("fee")]
        public string Fee { get; set; }

        [JsonPropertyName("horses")]
        public List<RaceHorse> Horses { get; set; }

        [JsonPropertyName("length")]
        public int Length { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("prize_pool")]
        public PrizePool PrizePool { get; set; }

        [JsonPropertyName("race_id")]
        public string RaceId { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("weather")]
        public string Weather { get; set; }
    }

    public class Edge
    {
        [JsonPropertyName("cursor")]
        public string Cursor { get; set; }

        [JsonPropertyName("node")]
        public Race Node { get; set; }
    }

    public class PageInfo
    {
        [JsonPropertyName("end_cursor")]
        public string EndCursor { get; set; }

        [JsonPropertyName("has_next_page")]
        public bool HasNextPage { get; set; }
    }

    public class GetRaceResults
    {
        [JsonPropertyName("edges")]
        public List<Edge> Edges { get; set; }

        [JsonPropertyName("page_info")]
        public PageInfo PageInfo { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("get_race_results")]
        public GetRaceResults GetRaceResults { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }


}
