using System.Diagnostics;
using ConfigCat.Client; // Import types from the ConfigCat SDK's namespace
using feature_flags_in_dotnet_mvc_sample.Models;
using Microsoft.AspNetCore.Mvc;

namespace feature_flags_in_dotnet_mvc_sample.Controllers;

// Inject the ConfigCat client via a constructor parameter
// so we can read the feature flag's value and pass it to the Views/Home/Index.cshtml file
// to control whether the "Join our mailing list" button is rendered
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
