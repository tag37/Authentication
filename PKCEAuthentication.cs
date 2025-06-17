using Microsoft.Identity.Client;

var clientId = "your-client-id";
var tenantId = "your-tenant-id"; // or 'common' for multi-tenant
var authority = $"https://login.microsoftonline.com/{tenantId}";
var scopes = new[] { "User.Read" }; // or your custom scope

var app = PublicClientApplicationBuilder
    .Create(clientId)
    .WithAuthority(authority)
    .WithRedirectUri("http://localhost")
    .Build();

try
{
    var accounts = await app.GetAccountsAsync();
    var result = await app.AcquireTokenSilent(scopes, accounts.FirstOrDefault())
                          .ExecuteAsync();

    Console.WriteLine("Token (silent): " + result.AccessToken);
}
catch (MsalUiRequiredException)
{
    var result = await app.AcquireTokenInteractive(scopes)
                          .WithUseEmbeddedWebView(false) // Launch system browser
                          .ExecuteAsync();

    Console.WriteLine("Token (interactive): " + result.AccessToken);
}
