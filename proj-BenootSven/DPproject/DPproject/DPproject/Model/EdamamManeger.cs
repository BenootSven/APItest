using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DPproject.Model
{
    public static class EdamamManeger
    {
        public const string APIKEY = "90ce976b3a0b3c6c6a2eaabb39940ad5";
        public const string USERTOKEN = "ee79ca6b";

        public static string AddKeyToken(string url)
        {
            return string.Format(url + "&app_id={0}&app_key={1}", USERTOKEN, APIKEY);
        }

        private static HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public static async Task<List<EdamamRecepten>> GetRecepies()
        {
            using (HttpClient client = GetClient())
            {
                string url = "https://api.edamam.com/search?q=chicken%20soup";
                url = AddKeyToken(url);

                try
                {
                    string result = await client.GetStringAsync(url);
                    return JsonConvert.DeserializeObject<List<EdamamRecepten>>(result);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
