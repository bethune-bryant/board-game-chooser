using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace BoardGameChooser
{
    class BGGInterface
    {
        static string BGGURL = @"https://boardgamegeek.com";
        private static dynamic RunQuery(string Query, string User, string Pass)
        {
            string URL = BGGURL + Query;

            string urlParameters = ""; // "?api_key=123";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
        "Basic",
        Convert.ToBase64String(
            System.Text.ASCIIEncoding.ASCII.GetBytes(
                string.Format("{0}:{1}", User, Pass))));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                string s = response.Content.ReadAsStringAsync().Result;

                dynamic stuff = JObject.Parse(s);

                return stuff;
            }
            else
            {
                throw new Exception((int)response.StatusCode + " " + response.ReasonPhrase);
            }
        }

        private static void RunPostQuery(string Query, string PostData, string User, string Pass)
        {
            string URL = BGGURL + Query;

            string urlParameters = ""; // "?api_key=123";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
        "Basic",
        Convert.ToBase64String(
            System.Text.ASCIIEncoding.ASCII.GetBytes(
                string.Format("{0}:{1}", User, Pass))));

            HttpContent content = new StringContent(PostData, Encoding.UTF8, "application/json");

            // List data response.
            //HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            HttpResponseMessage response = client.PostAsync(urlParameters, content).Result;

            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                string s = response.Content.ReadAsStringAsync().Result;

                dynamic stuff = JObject.Parse(s);
            }
            else
            {
                throw new Exception((int)response.StatusCode + " " + response.ReasonPhrase);
            }
        }
    }
}
