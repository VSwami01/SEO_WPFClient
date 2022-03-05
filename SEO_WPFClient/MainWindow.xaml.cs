using Newtonsoft.Json;
using SEO_WPFClient.Services;
using SEO_WPFClient.ViewModel;
using System;
using System.Net.Http;
using System.Windows;

namespace SEO_WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IWebApiService _webApiService;
        public MainWindow(IWebApiService webApiService)
        {
            InitializeComponent();
            _webApiService = webApiService;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchResult result = _webApiService.GetURLRanks(txtSearchText.Text, txtSearchUrl.Text);

            if (result == null)
                txtBlockResult.Text = "Could not connect to API";
            else
                txtBlockResult.Text = string.Format("Search: {0}{1}URL: {2}{3}Appearence: {4}{5}Ranks: {6}",
                    result.SearchText,
                    Environment.NewLine,
                    result.UrlToMatch,
                    Environment.NewLine,
                    result.TotalAppearence,
                    Environment.NewLine,
                    string.Join('\n', result.Rankings));
        }

    }

}
