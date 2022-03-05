using Newtonsoft.Json;
using SEO_WPFClient.ViewModel;
using System;
using System.Net.Http;

namespace SEO_WPFClient.Services
{
    public class WebApiService : IWebApiService
    {
        const string GETURLRANKS_URL = @"https://localhost:44318/api/Search/GetURLRanks";
        const string GETALLLINKS_URL = @"https://localhost:44318/api/Search/GetAllLinks";

        public SearchResult GetURLRanks(string searchText, string urlToMatch)
        {
            string query = string.Format("searchText={0}&urlToMatch={1}", searchText, urlToMatch);
            return CallApi<SearchResult>(GETURLRANKS_URL, query);
        }
        public string GetAllLinks(string searchText)
        {
            string query = string.Format("searchText={0}", searchText);
            return CallApi<string>(GETALLLINKS_URL, query);
        }

        private T CallApi<T>(string url, string query)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new(url)
                {
                    Query = query,
                };

                T responseObj = default(T);

                //API key for secured access
                client.DefaultRequestHeaders.Add("ApiKey", AppSettings.Settings.API_KEY);

                HttpResponseMessage response = client.GetAsync(builder.Uri).Result;

                // Verification  
                if (response.IsSuccessStatusCode)
                {
                    // Reading Response.  
                    string result = response.Content.ReadAsStringAsync().Result;
                    responseObj = JsonConvert.DeserializeObject<T>(result);

                    // Releasing.  
                    response.Dispose();
                }
                return responseObj;
            }
        }
    }
}
