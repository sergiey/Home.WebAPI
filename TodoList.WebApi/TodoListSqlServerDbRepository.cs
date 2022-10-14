using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;
using System.Web.Http;
using TodoList.WebApi.Model;

namespace TodoList.WebApi
{
    public class TodoListSqlServerDbRepository : IRepository<TodoListItem>
    {
        private string _connectionString;

        public TodoListSqlServerDbRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<TodoListItem> GetTodoList()
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            return db.Query<TodoListItem>("select * from TodoListItems");
        }

        public TodoListItem? GetTodoListItem(Guid id)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            var item = db.Query<TodoListItem>("select * from TodoListItems where Id = @id",
                new { id }).FirstOrDefault();
            if (item == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return item;
        }

        public void Create(TodoListItem item)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            db.Execute("insert into TodoListItems (TodoTask, IsDone, ScheduledTime)" +
                "values (@TodoTask, @IsDone, @ScheduledTime)", item);
        }

        public void Update(TodoListItem item)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            var request = db.Query<TodoListItem>("select * from TodoListItems where Id = @id",
                new { item.Id }).FirstOrDefault();
            if (request == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            db.Execute("update TodoListItems set TodoTask = @TodoTask, IsDone = @IsDone," +
                "ScheduledTime = @ScheduledTime where Id = @Id", item);
        }

        public void Delete(Guid id)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            var request = db.Query<TodoListItem>("select * from TodoListItems where Id = @id",
                new { id }).FirstOrDefault();
            if (request == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            db.Execute("delete from TodoListItems where Id = @id", new { id });
        }
    }
}
