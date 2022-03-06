# SEO_WPFClient
SEO_WPFClient is a utility that allows the user to perform a google search and then find the rank of a given url in the search result

Running the Project
1. Download the repo
2. Open SEO_WPFClient solution in Visual Studio 2022
3. Right click solution and click on Restore Nuget Packages to insatll all dependencies
4. Set SEO_WPFClient project as the starting project if it is not already set.
5. Make sure the server app, SEO_WebApi (https://github.com/VSwami01/SEO_WebApi.git), is up and running at default https://localhost:44318/. 
6. The api url is hardcoded in the client app settings. If api is running on a different location, modify it in the Client's app settings
7. The input fields are pre popucated in the Client App. Change the values in input field as required
8. Click on Search button
9. This should call the api in the background and show the result on the form
