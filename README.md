# How to Use Feature Flags in an ASP.NET Core MVC Application

This is a minimal sample app simulating a success page that appears once the user has successfully registered on the website. A feature flag is used in order to enable/disable a message that invites the user to subscribe to the newsletter. For managing the flag, ConfigCat's feature flag management system is used.

## Setup and Run

1. Clone this repository.
2. Open the project in Visual Studio Code or any other .NET and C#-compatible IDE.
3. In `appsettings.Development.json` and `appsettings.json`, within the `ConfigCat` block, replace the placeholder with your actual ConfigCat SDK Key. It is recommended to use separate SDK Keys for development and production.
4. Launch the app with the following command:
   ```bash
   dotnet run
   ```

Go to the ConfigCat Dashboard to enable/disable the feature flag. Wait a few seconds for the change to propagate, then refresh the page in your browser.

## Learn more

- Read more about ASP.NET Core MVC [here](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview).
- Learn more about feature flags [here](https://configcat.com/featureflags/).

[**ConfigCat**](https://configcat.com) also supports many other frameworks and languages. Check out the full list of supported SDKs [here](https://configcat.com/docs/sdk-reference/overview/).

You can also explore other code samples for various languages, frameworks, and topics here in the [ConfigCat labs](https://github.com/configcat-labs) on GitHub.

Keep up with ConfigCat on [X](https://x.com/configcat), [Facebook](https://www.facebook.com/configcat), [LinkedIn](https://www.linkedin.com/company/configcat/), [GitHub](https://github.com/configcat), and the [News & Product Updates](https://configcat.com/docs/news/) page.

## Authors

- [Roxana Halati](https://github.com/roxanahalati)
- [Chavez Harris](https://github.com/codedbychavez)

## Contributions

Contributions are welcome!
