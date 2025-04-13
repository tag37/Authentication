using Microsoft.AspNetCore.Mvc;

namespace Smart.Authentication.Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthTestController : ControllerBase
    {
        public HttpClient HttpClient { get; set; }
        public HttpClient HttpClient2 { get; set; }
        public AuthTestController(IHttpClientFactory httpClientFactory)
        {
            HttpClient = httpClientFactory.CreateClient("httpClient");
            HttpClient2 = httpClientFactory.CreateClient("httpClient2");
        }

        [HttpGet("authenticate")]
        public async Task<IActionResult> Authenticate()
        {
            var response = await HttpClient.GetAsync("http://httpbin.org/basic-auth/foo/bar", CancellationToken.None);

            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Ok(content);
            }
            else
            {
                return BadRequest("Authentication failed");
            }
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
