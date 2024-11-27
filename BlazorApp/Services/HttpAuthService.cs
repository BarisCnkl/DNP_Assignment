using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ApiContracts;

namespace BlazorApp.Services
{
    public class HttpAuthService : IAuthService
    {
        private readonly HttpClient _client;

        public HttpAuthService(HttpClient client)
        {
            _client = client;
        }

        public async Task<UserDTO> LoginAsync(string username, string password)
        {
            var loginRequest = new LoginRequest
            {
                UserName = username,
                Password = password
            };

            HttpResponseMessage response = await _client.PostAsJsonAsync("api/auth/login", loginRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Login failed. Invalid credentials.");
            }

            string responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<UserDTO>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            })!;
        }
    }
}