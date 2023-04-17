
using FQ23L056_ConsumeApi.Dal.Entities;
using System;
using System.Net.Http.Json;
using System.Text.Json;

namespace FQ23L056_ConsumeApi.Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Get All
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    httpClient.BaseAddress = new Uri("https://localhost:7296/api/");

            //    using (HttpResponseMessage httpResponseMessage = httpClient.GetAsync("task").Result)
            //    {
            //        //httpResponseMessage.EnsureSuccessStatusCode();
            //        //XOR
            //        if (httpResponseMessage.IsSuccessStatusCode)
            //        {
            //            string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
            //            IEnumerable<UserTask>? tasks = JsonSerializer.Deserialize<IEnumerable<UserTask>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            //            if(tasks is not null)
            //            {
            //                foreach (var task in tasks) 
            //                {
            //                    Console.WriteLine($"{task.Id} : {task.Title} ({(task.Done ? "Terminée" : "En cours")})");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Erreur code : {httpResponseMessage.StatusCode}");
            //        }
            //    }
            //}
            #endregion

            #region Get One
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    httpClient.BaseAddress = new Uri("https://localhost:7296/api/");

            //    int id = 1;

            //    using (HttpResponseMessage httpResponseMessage = httpClient.GetAsync($"task/{id}").Result)
            //    {
            //        //httpResponseMessage.EnsureSuccessStatusCode();
            //        //XOR
            //        if (httpResponseMessage.IsSuccessStatusCode)
            //        {
            //            string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
            //            UserTask? task = JsonSerializer.Deserialize<UserTask>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            //            if (task is not null)
            //            {
            //                    Console.WriteLine($"{task.Id} : {task.Title} ({(task.Done ? "Terminée" : "En cours")})");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Erreur code : {httpResponseMessage.StatusCode}");
            //        }
            //    }
            //}
            #endregion

            #region Post
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    httpClient.BaseAddress = new Uri("https://localhost:7296/api/");
            //    UserTask userTask = new UserTask() { Title = "Test" };

            //    HttpContent httpContent = JsonContent.Create(new { title = userTask.Title });

            //    using (HttpResponseMessage httpResponseMessage = httpClient.PostAsync($"task", httpContent).Result)
            //    {
            //        //httpResponseMessage.EnsureSuccessStatusCode();
            //        //XOR
            //        if (httpResponseMessage.IsSuccessStatusCode)
            //        {
            //            Console.WriteLine("Tâche créée...");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Erreur code : {httpResponseMessage.StatusCode}");
            //        }
            //    }
            //}
            #endregion

            #region Put
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    httpClient.BaseAddress = new Uri("https://localhost:7296/api/");
            //    UserTask userTask = new UserTask() { Id = 3, Title = "Test 2", Done = true };

            //    HttpContent httpContent = JsonContent.Create(new { title = userTask.Title, done = userTask.Done });

            //    using (HttpResponseMessage httpResponseMessage = httpClient.PutAsync($"task/{userTask.Id}", httpContent).Result)
            //    {
            //        //httpResponseMessage.EnsureSuccessStatusCode();
            //        //XOR
            //        if (httpResponseMessage.IsSuccessStatusCode)
            //        {
            //            Console.WriteLine("Tâche mise à jour...");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Erreur code : {httpResponseMessage.StatusCode}");
            //        }
            //    }
            //}
            #endregion

            #region Delete
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    httpClient.BaseAddress = new Uri("https://localhost:7296/api/");
            //    int id = 3;

            //    using (HttpResponseMessage httpResponseMessage = httpClient.DeleteAsync($"task/{id}").Result)
            //    {
            //        //httpResponseMessage.EnsureSuccessStatusCode();
            //        //XOR
            //        if (httpResponseMessage.IsSuccessStatusCode)
            //        {
            //            Console.WriteLine("Tâche supprimée...");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Erreur code : {httpResponseMessage.StatusCode}");
            //        }
            //    }
            //}
            #endregion

            #region Get All
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    httpClient.BaseAddress = new Uri("https://localhost:7296/api/");

            //    using (HttpResponseMessage httpResponseMessage = httpClient.GetAsync("task").Result)
            //    {
            //        //httpResponseMessage.EnsureSuccessStatusCode();
            //        //XOR
            //        if (httpResponseMessage.IsSuccessStatusCode)
            //        {
            //            string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
            //            IEnumerable<UserTask>? tasks = JsonSerializer.Deserialize<IEnumerable<UserTask>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            //            if (tasks is not null)
            //            {
            //                foreach (var task in tasks)
            //                {
            //                    Console.WriteLine($"{task.Id} : {task.Title} ({(task.Done ? "Terminée" : "En cours")})");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Erreur code : {httpResponseMessage.StatusCode}");
            //        }
            //    }
            //}
            #endregion
        }
    }
}