using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ConfigCat.Client;
using feature_flags_in_dotnet_mvc_sample.Models; // Import types from the ConfigCat SDK's

namespace feature_flags_in_dotnet_mvc_sample.Controllers;

// Inject the ConfigCat client via a constructor parameter
// so we can read the reference flag's value and pass it to the View/Home/index.cshtml file
// to control whether the sign-up button is rendered
public class HomeController(IConfigCatClient configCatClient) : Controller
{
    public async Task<IActionResult> Index()
    {
        // Get the flag's latest value
        var mailingListEnabled = await configCatClient.GetValueAsync("mailingListEnabled", false);

        return View(new IndexViewModel { MailingListEnabled = mailingListEnabled });
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
