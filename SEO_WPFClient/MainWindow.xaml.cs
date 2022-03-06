using Microsoft.Extensions.Logging;
using SEO_WPFClient.Services;
using SEO_WPFClient.ViewModel;
using System;
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

        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SearchResult result = await _webApiService.GetURLRanksAsync(txtSearchText.Text, txtSearchUrl.Text);

                if (result == null)
                    txtBlockResult.Text = "Could not fetch result from server";
                else
                    txtBlockResult.Text = string.Format("Search: {0}{1}URL: {2}{3}Is In Top Hundred: {4}{5}Total Appearences: {6}{7}Ranks: {8}",
                        result.SearchText,
                        Environment.NewLine,
                        result.UrlToMatch,
                        Environment.NewLine,
                        result.IsInTopHundred ? "Yes" : "No",
                        Environment.NewLine,
                        result.TotalAppearence,
                        Environment.NewLine,
                        string.Join('\n', result.Rankings));
            }
            catch (Exception ex)
            {
                txtBlockResult.Text = "Could not fetch result from server";
            }
        }

    }

}
