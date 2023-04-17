using FQ23L056_ConsumeApi.Bll.Services;
using DR = FQ23L056_ConsumeApi.Dal.Repositories;
using DS = FQ23L056_ConsumeApi.Dal.Services;

namespace FQ23L056_ConsumeApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddHttpClient("default", client =>
            {
                client.BaseAddress = new Uri("https://localhost:7296/api/");
            });

            builder.Services.AddScoped(sp =>
            {
                IHttpClientFactory? httpClientFactory = sp.GetService<IHttpClientFactory>();
                if (httpClientFactory is null)
                    throw new InvalidOperationException();

                return httpClientFactory.CreateClient("default");
            });

            builder.Services.AddScoped<DR.ITaskRepository, DS.TaskService>();
            builder.Services.AddScoped<ITaskRepository, TaskService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}