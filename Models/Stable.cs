using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ZedSharp.Models
{
    public class Career
    {
        [JsonPropertyName("first")]
        public int First { get; set; }

        [JsonPropertyName("second")]
        public int Second { get; set; }

        [JsonPropertyName("third")]
        public int Third { get; set; }
    }

    public class StableAvatarUrls
    {
        [JsonPropertyName("original")]
        public string Original { get; set; }

        [JsonPropertyName("thumb")]
        public string Thumb { get; set; }
    }

    public class StableStats
    {
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        [JsonPropertyName("career")]
        public Career Career { get; set; }

        [JsonPropertyName("discord_id")]
        public object DiscordId { get; set; }

        [JsonPropertyName("is_email_verified")]
        public bool IsEmailVerified { get; set; }

        [JsonPropertyName("public_address")]
        public string PublicAddress { get; set; }

        [JsonPropertyName("stable_avatar_urls")]
        public StableAvatarUrls StableAvatarUrls { get; set; }

        [JsonPropertyName("stable_description")]
        public object StableDescription { get; set; }

        [JsonPropertyName("stable_name")]
        public string StableName { get; set; }

        [JsonPropertyName("stable_slug")]
        public string StableSlug { get; set; }

        [JsonPropertyName("thoroughbreds")]
        public int Thoroughbreds { get; set; }

        [JsonPropertyName("win_rate")]
        public double WinRate { get; set; }
    }

    public class Stable
    {
        [JsonPropertyName("stable_stats")]
        public StableStats StableStats { get; set; }
    }
}
