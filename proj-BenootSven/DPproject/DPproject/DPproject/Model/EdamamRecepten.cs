using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DPproject.Model
{
    public class EdamamRecepten
    {
        [JsonProperty("q")]
        public string Q { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }


        [JsonProperty("more")]
        public bool More { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("hits")]
        public List<Hit> Hits { get; set; }
    }
}

