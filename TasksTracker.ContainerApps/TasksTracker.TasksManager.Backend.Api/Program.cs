using Dapr.Client;
using TasksTracker.TasksManager.Backend.Api.Services;

namespace TasksTracker.TasksManager.Backend.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            //builder.Services.AddSingleton<ITasksManager, FakeTasksManager>();
            builder.Services.AddSingleton<DaprClient>(_ => new DaprClientBuilder().Build());
            builder.Services.AddSingleton<ITasksManager, TasksStoreManager>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
