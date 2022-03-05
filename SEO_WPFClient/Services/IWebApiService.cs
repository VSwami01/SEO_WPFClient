using SEO_WPFClient.ViewModel;
using System.Threading.Tasks;

namespace SEO_WPFClient.Services
{
    public interface IWebApiService
    {
        Task<SearchResult> GetURLRanksAsync(string searchText, string urlToMatch);
        Task<string> GetAllLinks(string searchText);
    }
}
