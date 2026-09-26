using System.Net.Http.Json;
using System.Reflection.Metadata.Ecma335;

namespace task_tracker.AccessApiService
{
    public class AccessApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string? _baseUrl = "https://localhost:7212/api";

        public AccessApiService(HttpClient client)
        {
            _httpClient = client;
        }

        //public string GetBaseUrl() => $"{_baseUrl}";

        public string GetItemUrl(int id) => $"{_baseUrl}/tasks/{id}";

        public async Task<List<Entities.Task>> GetAllTasks() 
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/tasks");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<Entities.Task>>() ?? new List<Entities.Task>();
        }

        public async Task<Entities.Task> CreateTask(Entities.Task task) 
        {
            var response = await _httpClient.PostAsJsonAsync($"{_baseUrl}/tasks", task);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Entities.Task>();
        }

        public async Task UpdateTask(int id, Entities.Task task) 
        {  
            var response = await _httpClient.PutAsJsonAsync(GetItemUrl(id), task);
            response.EnsureSuccessStatusCode();
        }

        public async Task<Entities.Task> GetTaskById(int id) 
        {
            var response = await _httpClient.GetAsync(GetItemUrl(id));
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Entities.Task>();
        }

        public async Task DeleteTask(int id) 
        {
            var response = await _httpClient.DeleteAsync(GetItemUrl(id));
            response.EnsureSuccessStatusCode();
        }
    }
}
