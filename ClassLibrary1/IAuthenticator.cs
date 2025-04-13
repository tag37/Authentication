using Authentication.Models;

namespace Authtication
{
    public interface IAuthenticator
    {
        Task AuthenticateAsync(HttpClient httpClient);
    }
}
