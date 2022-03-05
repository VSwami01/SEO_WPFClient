using SEO_WPFClient.ViewModel;

namespace SEO_WPFClient.Services
{
    public interface IWebApiService
    {
        SearchResult GetURLRanks(string searchText, string urlToMatch);
        string GetAllLinks(string searchText);
    }
}
