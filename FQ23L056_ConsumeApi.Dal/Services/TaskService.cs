using FQ23L056_ConsumeApi.Dal.Entities;
using FQ23L056_ConsumeApi.Dal.Repositories;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace FQ23L056_ConsumeApi.Dal.Services
{
    public class TaskService : ITaskRepository
    {
        private readonly HttpClient _httpClient;

        public TaskService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IEnumerable<UserTask> Get()
        {
            using (HttpResponseMessage httpResponseMessage = _httpClient.GetAsync("task").Result)
            {
                httpResponseMessage.EnsureSuccessStatusCode();
                
                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<IEnumerable<UserTask>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true })!;
            }
        }

        public UserTask? Get(int id)
        {
            using (HttpResponseMessage httpResponseMessage = _httpClient.GetAsync($"task/{id}").Result)
            {
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<UserTask>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }

        public bool Insert(UserTask entity)
        {
            HttpContent httpContent = JsonContent.Create(new { title = entity.Title });

            using (HttpResponseMessage httpResponseMessage = _httpClient.PostAsync($"task", httpContent).Result)
            {
                httpResponseMessage.EnsureSuccessStatusCode();
                return true;
            }
        }

        public bool Update(UserTask entity)
        {
            HttpContent httpContent = JsonContent.Create(new { title = entity.Title, done = entity.Done });

            using (HttpResponseMessage httpResponseMessage = _httpClient.PutAsync($"task/{entity.Id}", httpContent).Result)
            {
                httpResponseMessage.EnsureSuccessStatusCode();
                return true;
            }
        }

        public bool Delete(int id)
        {
            using (HttpResponseMessage httpResponseMessage = _httpClient.DeleteAsync($"task/{id}").Result)
            {
                httpResponseMessage.EnsureSuccessStatusCode();
                return true;
            }
        }
    }
}
