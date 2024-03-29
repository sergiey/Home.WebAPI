﻿using Dapper;
using Microsoft.Extensions.Options;
using Npgsql;
using System.Data;
using System.Net;
using System.Web.Http;
using TodoList.WebApi.Model;

namespace TodoList.WebApi
{
    public class TodoListPostgresDbRepository : IRepository<TodoListItem>
    {
        private readonly string _connectionString;

        public TodoListPostgresDbRepository(IOptions<TodoListWebApiOptions> options)
        {
            _connectionString = options.Value.ConnectionString;
        }

        public IEnumerable<TodoListItem> GetTodoList()
        {
            using IDbConnection db = new NpgsqlConnection(_connectionString);
            var sqlQuery = @"
                SELECT ""Id"",
                       ""TodoTask"",
                       ""IsDone"",
                       ""ScheduledTime"" 
                FROM ""TodoListItems""";
            return db.Query<TodoListItem>(sqlQuery);
        }

        public TodoListItem? GetTodoListItem(Guid id)
        {
            using IDbConnection db = new NpgsqlConnection(_connectionString);
            var sqlQuery = @"
                SELECT ""Id"",
                       ""TodoTask"",
                       ""IsDone"",
                       ""ScheduledTime""
                FROM ""TodoListItems""
                WHERE ""Id"" = @id";
            var item = db.Query<TodoListItem>(sqlQuery, new { id }).FirstOrDefault();
            if (item == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return item;
        }

        public void Create(TodoListItem item)
        {
            using IDbConnection db = new NpgsqlConnection(_connectionString);
            var sqlQuery = @"
                INSERT INTO ""TodoListItems""
                (
                  ""Id"",
                  ""TodoTask"",
                  ""IsDone"",
                  ""ScheduledTime""
                )
                VALUES 
                (@Id, @TodoTask, @IsDone, @ScheduledTime)";
            db.Execute(sqlQuery, item);
        }

        public void Update(TodoListItem item)
        {
            using IDbConnection db = new NpgsqlConnection(_connectionString);
            var sqlQuery = @" 
                SELECT ""Id"",
                       ""TodoTask"",
                       ""IsDone"",
                       ""ScheduledTime"" 
                FROM ""TodoListItems""
                WHERE ""Id"" = @id";
            var request = db.Query<TodoListItem>(sqlQuery, new { item.Id }).FirstOrDefault();
            if (request == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            
            sqlQuery = @"
                UPDATE ""TodoListItems""
                SET ""TodoTask"" = @TodoTask,
                    ""IsDone"" = @IsDone,
                    ""ScheduledTime"" = @ScheduledTime
                WHERE ""Id"" = @Id";
            db.Execute(sqlQuery, item);
        }

        public void Delete(Guid id)
        {
            using IDbConnection db = new NpgsqlConnection(_connectionString);
            var sqlQuery = @"
                SELECT ""Id"",
                       ""TodoTask"",
                       ""IsDone"",
                       ""ScheduledTime""
                FROM ""TodoListItems""
                WHERE ""Id"" = @id";
            var request = db.Query<TodoListItem>(sqlQuery, new { id }).FirstOrDefault();
            if (request == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            sqlQuery = @"
                DELETE FROM ""TodoListItems""
                WHERE ""Id"" = @id";
            db.Execute(sqlQuery, new { id });
        }
    }
}
