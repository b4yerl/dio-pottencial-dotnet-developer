using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IntroCSharpII.Models
{
    public class Placar
    {
        [JsonProperty("ft")]
        public int[] FullTime { get; set; }
    }
}