using TodoList.WebApi.Model;

namespace TodoList.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = "Server=localhost;Database=todolist;Encrypt=False;Trusted_Connection=True;";

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddTransient<IRepository<TodoListItem>, TodoListSqlServerDbRepository>
                (x => new TodoListSqlServerDbRepository(connectionString));

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