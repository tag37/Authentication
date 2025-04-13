using System.Net.Http.Headers;
using System.Text;
using Authentication.Models;
using Authtication;

namespace Authentication
{
    public class BasicAuthenticator : IAuthenticator
    {
        private readonly BasicAuthOptions _options;

        public BasicAuthenticator(BasicAuthOptions options)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(options?.Username, nameof(options.Username));
            ArgumentException.ThrowIfNullOrWhiteSpace(options?.Password, nameof(options.Password));
            _options = options;
        }

        public virtual Task AuthenticateAsync(HttpClient httpClient)
        {
            var credentials = $"{_options.Username}:{_options.Password}";
            var base64Credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64Credentials);
            return Task.CompletedTask;
        }
    }
}