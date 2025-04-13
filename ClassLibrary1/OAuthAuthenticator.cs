using System.Net.Http.Headers;
using System.Text.Json;
using Authentication.Models;
using Authtication;

namespace Authentication
{
    public class OAuthAuthenticator : IAuthenticator
    {
        private readonly OAuthAuthOptions _options;
        private string? _accessToken;
        private DateTime _tokenExpiry;

        public OAuthAuthenticator(OAuthAuthOptions options)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(options?.ClientId, nameof(options.ClientId));
            ArgumentException.ThrowIfNullOrWhiteSpace(options?.ClientSecret, nameof(options.ClientSecret));
            ArgumentException.ThrowIfNullOrEmpty(options?.ClientSecret, nameof(options.ClientSecret));
            _options = options;
        }

        public virtual async Task AuthenticateAsync(HttpClient httpClient)
        {
            if (string.IsNullOrWhiteSpace(_accessToken) || DateTime.UtcNow >= _tokenExpiry)
            {
                await RefreshTokenAsync(httpClient);
            }
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
            //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
        }

        private async Task RefreshTokenAsync(HttpClient httpClient)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, _options.TokenEndpoint);
            var content = new FormUrlEncodedContent(new[]
            {
            new KeyValuePair<string, string>("client_id", _options.ClientId),
            new KeyValuePair<string, string>("client_secret", _options.ClientSecret)
            });

            request.Content = content;

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var tokenResponse = JsonSerializer.Deserialize<OAuthTokenResponse>(responseContent);
            _accessToken = tokenResponse.AccessToken;
            // We subtract 60 seconds to ensure we refresh the token before it expires
            _tokenExpiry = DateTime.UtcNow.AddSeconds(tokenResponse.ExpiresIn - 60);
        }
    }
}
