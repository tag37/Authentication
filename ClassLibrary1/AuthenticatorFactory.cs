using Authentication.Models;
using Authtication;

namespace Authentication
{
    public static class AuthenticatorFactory
    {
        public static IAuthenticator Create(AuthOptionsBase options)
        {
            return options.Type switch
            {
                AuthenticationType.OAuth2 => new OAuthAuthenticator((OAuthAuthOptions)options),
                _ => throw new ArgumentException("Unsupported authentication type")
            };
        }
    }
}
