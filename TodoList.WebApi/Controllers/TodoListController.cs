using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TodoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private static List<TodoListItem> s_todoListItems = new List<TodoListItem>
        {
            new TodoListItem
            {
                Id = 1,
                TodoTask = "Buy some milk",
                IsDone = false,
                ScheduledTime = new DateTime(2022, 09, 01)
            },
            new TodoListItem
            {
                Id = 2,
                TodoTask = "Do workout",
                IsDone = false,
                ScheduledTime = new DateTime(2022, 09, 02)
            }
        };

        [HttpGet(Name = "GetTodoList")]
        public ActionResult<List<TodoListItem>> GetTodoList()
        {
            return Ok(s_todoListItems);
        }

        [HttpGet("{id}", Name = "GetTodoListItem")]
        public ActionResult GetTodoListItem(int id)
        {
            var item = s_todoListItems.Find(x => x.Id == id);
            return item == null ? BadRequest("Item not found") : Ok(item);
        }

        [HttpPost(Name = "AddTodoListItem")]
        public ActionResult AddTodoListItem(TodoListItem item)
        {
            s_todoListItems.Add(item);
            return Ok(s_todoListItems);
        }

        [HttpPut(Name = "UpdateTodoListItem")]
        public ActionResult UpdateTodoListItem(TodoListItem request)
        {
            var item = s_todoListItems.Find(x => x.Id == request.Id);
            if (item == null)
                return BadRequest("Item not found");
            item.TodoTask = request.TodoTask;
            item.IsDone = request.IsDone;
            item.ScheduledTime = request.ScheduledTime;
            return Ok(item);
        }

        [HttpDelete("{id}", Name = "DeleteTodoListItem")]
        public ActionResult DeleteTodoListItem(int id)
        {
            var item = s_todoListItems.Find(x => x.Id == id);
            if (item == null)
                return BadRequest("Item not found");
            s_todoListItems.Remove(item);
            return Ok(item);
        }
    }
}
