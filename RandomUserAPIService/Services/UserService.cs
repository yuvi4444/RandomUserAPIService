using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using RandomUserAPIService.Models;

using Xamarin.Forms;

namespace RandomUserAPIService.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<User> GetRandomUserAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<ApiResponse>("https://randomuser.me/api/");
            return response.Results.FirstOrDefault();
        }
    }

    public class ApiResponse
    {
        public List<User> Results { get; set; }
    }
}