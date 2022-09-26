using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.WebApi.Model;

namespace TodoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private static IRepository<TodoListItem> s_repository;

        public TodoListController(IRepository<TodoListItem> repository)
        {
            s_repository = repository;
        }

        [HttpGet(Name = "GetTodoList")]
        public IActionResult GetTodoList()
        {
            return Ok(s_repository.GetTodoList());
        }

        [HttpGet("{id}", Name = "GetTodoListItem")]
        public IActionResult GetTodoListItem(int id)
        {
            try
            {
                var item = s_repository.GetTodoListItem(id);
                return Ok(item);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost(Name = "AddTodoListItem")]
        public IActionResult AddTodoListItem(TodoListItem item)
        {
            try
            {
                s_repository.Create(item);
                return Ok(s_repository.GetTodoListItem(item.Id));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut(Name = "UpdateTodoListItem")]
        public IActionResult UpdateTodoListItem(TodoListItem item)
        {
            try
            {
                s_repository.Update(item);
                return Ok(s_repository.GetTodoListItem(item.Id));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}", Name = "DeleteTodoListItem")]
        public IActionResult DeleteTodoListItem(int id)
        {
            try
            {
                s_repository.Delete(id);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
