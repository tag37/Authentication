using Authtication;

namespace Authentication
{
    public static class HttpClientExtensions
    {
        public static HttpClient AddAuthentication(this HttpClient client, IAuthenticator authenticator)
        {
            client.DefaultRequestHeaders.Clear();
            authenticator.AuthenticateAsync(client).Wait();
            return client;
        }

        public static async Task<HttpResponseMessage> GetAuthAsync(
            this HttpClient client, IAuthenticator authenticator, string requestUri, CancellationToken cancellationToken)
        {
            await authenticator.AuthenticateAsync(client);
            return await client.GetAsync(requestUri, cancellationToken);
        }
    }
}
