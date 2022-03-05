using System.Collections.Generic;

namespace SEO_WPFClient.ViewModel
{
    public class SearchResult
    {
        public string SearchText { get; set; }
        public string UrlToMatch { get; set; }
        public IList<int> Rankings { get; set; }
        public int TotalAppearence => Rankings.Count;
    }
}
