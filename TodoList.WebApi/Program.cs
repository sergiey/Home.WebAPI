using Microsoft.AspNetCore.Hosting.Server;
using TodoList.WebApi.Model;

namespace TodoList.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.Configure<TodoListWebApiOptions>(
                builder.Configuration.GetSection(TodoListWebApiOptions.TodoListWebApi));

            builder.Services.AddTransient<
                IRepository<TodoListItem>, TodoListPostgresDbRepository>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.MapControllers();

            app.Run();
        }
    }
}