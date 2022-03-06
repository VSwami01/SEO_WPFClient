using Newtonsoft.Json;
using SEO_WPFClient.AppSettings;
using SEO_WPFClient.ViewModel;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SEO_WPFClient.Services
{
    public class WebApiService : IWebApiService
    {
        /// <summary>
        /// Call api to get the rank of the given url based on search result
        /// </summary>
        /// <param name="searchText"></param>
        /// <param name="urlToMatch"></param>
        /// <returns></returns>
        public async Task<SearchResult> GetURLRanksAsync(string searchText, string urlToMatch)
        {

            string query = string.Format("searchText={0}&urlToMatch={1}", searchText, urlToMatch);
            return await CallApi<SearchResult>(Settings.GETURLRANKS_URL, query);
        }

        /// <summary>
        /// Call api to get all links in the result of the search
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public async Task<string> GetAllLinks(string searchText)
        {
            string query = string.Format("searchText={0}", searchText);
            return await CallApi<string>(Settings.GETALLLINKS_URL, query);
        }

        /// <summary>
        /// Call an api with query parametes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        private async Task<T> CallApi<T>(string url, string query)
        {
            using (var client = new HttpClient())
            {
                UriBuilder builder = new(url)
                {
                    Query = query,
                };

                T responseObj = default(T);

                //API key for secured access
                client.DefaultRequestHeaders.Add("ApiKey", Settings.API_KEY);

                HttpResponseMessage response = client.GetAsync(builder.Uri).Result;

                // Verification  
                if (response.IsSuccessStatusCode)
                {
                    // Reading Response.  
                    string result = await response.Content.ReadAsStringAsync();
                    responseObj = JsonConvert.DeserializeObject<T>(result);

                    // Releasing.  
                    response.Dispose();
                }
                return responseObj;
            }
        }
    }
}
