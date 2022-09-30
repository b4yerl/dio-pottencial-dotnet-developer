using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IntroCSharpII.Models
{
    public class JogoBrasileirao
    {
        [JsonProperty("round")]
        public string Round { get; set; }
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("team1")]
        public string HomeTeam { get; set; }
        [JsonProperty("team2")]
        public string AwayTeam { get; set; }
        [JsonProperty("score")]
        public Placar Score { get; set; }
    }
}