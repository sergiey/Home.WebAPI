using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.WebApi.Model;

namespace TodoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private readonly IRepository<TodoListItem> _repository;

        public TodoListController(IRepository<TodoListItem> repository)
        {
            _repository = repository;
        }

        [HttpGet(Name = "GetTodoList")]
        public IActionResult GetTodoList()
        {
            return Ok(_repository.GetTodoList());
        }

        [HttpGet("{id}", Name = "GetTodoListItem")]
        public IActionResult GetTodoListItem(int id)
        {
            try
            {
                var item = _repository.GetTodoListItem(id);
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
                _repository.Create(item);
                return Ok(_repository.GetTodoListItem(item.Id));
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
                _repository.Update(item);
                return Ok(_repository.GetTodoListItem(item.Id));
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
                _repository.Delete(id);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
