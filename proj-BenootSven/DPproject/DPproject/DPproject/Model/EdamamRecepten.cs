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
            [JsonProperty("calories")]
            public double Calories { get; set; }

            [JsonProperty("cautions")]
            public string[] Cautions { get; set; }

            [JsonProperty("dietLabels")]
            public string[] DietLabels { get; set; }

            [JsonProperty("healthLabels")]
            public string[] HealthLabels { get; set; }

            [JsonProperty("image")]
            public string Image { get; set; }

            [JsonProperty("ingredientLines")]
            public string[] IngredientLines { get; set; }

            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("shareAs")]
            public string ShareAs { get; set; }

            [JsonProperty("source")]
            public string Source { get; set; }

            [JsonProperty("totalWeight")]
            public double TotalWeight { get; set; }

            [JsonProperty("uri")]
            public string Uri { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("yield")]
            public long Yield { get; set; }
    }
}

