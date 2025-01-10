using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WebApi.Client.Models;
using WebApi.Client.Models.ApiModels;

namespace WebApi.Client
{
    public class WebApiClientService
    {
        private readonly HttpClient _httpClient;

        public WebApiClientService(ApiClientOptions apiClientOptions)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new System.Uri(apiClientOptions.ApiBaseAddress);
        }

        public async Task<List<User>?> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<List<User>?>("/api/User/get-users");
        }

        public async Task<User?> GetUserById(int userId)
        {
            return await _httpClient.GetFromJsonAsync<User?>($"/api/User/get-user/{userId}");
        }

        public async Task SaveUser(User user)
        {
            await _httpClient.PostAsJsonAsync("/api/User/add-user", user);
        }

        public async Task UpdateUser(User user)
        {
            await _httpClient.PostAsJsonAsync("/api/User/update-user", user);
        }

        public async Task DeleteUser(int userId)
        {
            await _httpClient.DeleteAsync($"/api/User/delete/{userId}");
        }
    }
}
