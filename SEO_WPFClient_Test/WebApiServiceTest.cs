using NUnit.Framework;
using SEO_WPFCLient_Lib.Model;
using SEO_WPFCLient_Lib.Services;

namespace SEO_WPFClient_Test
{
    public class WebApiServiceTest
    { 
        private IWebApiService _webApiService;
        public WebApiServiceTest()
        {
            _webApiService = new WebApiService();
        }

        /// <summary>
        /// Test with empty search text parameter returning null
        /// </summary>
        [Test]
        public void GetURLRanksAsync_EmptySearchText_ReturnNull()
        {
            // Arrange
            var searchText = string.Empty;
            var urlToMatch = string.Empty;
            SearchResult expected = null;

            // Act
            var actual = _webApiService.GetURLRanksAsync(searchText, urlToMatch).Result;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with null search text parameter returning null
        /// </summary>
        [Test]
        public void GetURLRanksAsync_NullSearchText_ReturnNull()
        {
            // Arrange
            string searchText = null;
            var urlToMatch = string.Empty;
            SearchResult expected = null;

            // Act
            var actual = _webApiService.GetURLRanksAsync(searchText, urlToMatch).Result;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with empty UrlToMatch text parameter returning null
        /// </summary>
        [Test]
        public void GetURLRanksAsync_EmptyUrlToMatchText_ReturnNull()
        {
            // Arrange
            var searchText = string.Empty;
            var urlToMatch = string.Empty;
            SearchResult expected = null;

            // Act
            var actual = _webApiService.GetURLRanksAsync(searchText, urlToMatch).Result;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with null UrlToMatch text parameter returning null
        /// </summary>
        [Test]
        public void GetURLRanksAsync_NullUrlToMatch_ReturnNull()
        {
            // Arrange
            var searchText = string.Empty;
            string urlToMatch = null;
            SearchResult expected = null;

            // Act
            var actual = _webApiService.GetURLRanksAsync(searchText, urlToMatch).Result;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with empty search text parameter returning null
        /// </summary>
        [Test]
        public void GetAllLinksAsync_EmptySearchText_ReturnNull()
        {
            // Arrange
            var searchText = string.Empty;
            SearchResult expected = null;

            // Act
            var actual = _webApiService.GetAllLinksAsync(searchText).Result;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test with null search text parameter returning null
        /// </summary>
        [Test]
        public void GetAllLinksAsync_NullSearchText_ReturnNull()
        {
            // Arrange
            string searchText = null;
            SearchResult expected = null;

            // Act
            var actual = _webApiService.GetAllLinksAsync(searchText).Result;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
