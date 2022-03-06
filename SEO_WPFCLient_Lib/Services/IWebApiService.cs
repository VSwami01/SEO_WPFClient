using SEO_WPFCLient_Lib.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SEO_WPFCLient_Lib.Services
{
    public interface IWebApiService
    {
        Task<SearchResult> GetURLRanksAsync(string searchText, string urlToMatch);
        Task<IEnumerable<string>> GetAllLinksAsync(string searchText);
    }
}
