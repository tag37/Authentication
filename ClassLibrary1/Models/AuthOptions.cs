namespace Authentication.Models
{
    public enum AuthenticationType
    {
        None,
        Basic,
        ApiKey,
        OAuth2
    }

    public class AuthOptions
    {
        public AuthenticationType Type { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ApiKey { get; set; }
        public string Token { get; set; } // For OAuth
        public string TokenEndpoint { get; set; } // For OAuth
        public string ClientId { get; set; } // For OAuth
        public string ClientSecret { get; set; } // For OAuth
        public string ApiKeyHeader { get; set; } = "X-API-KEY"; // Default header for API key
    }

    public abstract class AuthOptionsBase
    {
        public virtual AuthenticationType Type { get; set; }
    }

    public class OAuthAuthOptions : AuthOptionsBase
    {
        public override AuthenticationType Type => AuthenticationType.OAuth2;
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string TokenEndpoint { get; set; }
    }

    public class BasicAuthOptions : AuthOptionsBase
    {
        public override AuthenticationType Type => AuthenticationType.Basic;
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
