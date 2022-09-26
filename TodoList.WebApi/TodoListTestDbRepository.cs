using TodoList.WebApi.Model;

namespace TodoList.WebApi
{
    public class TodoListTestDbRepository : IRepository<TodoListItem>
    {
        private List<TodoListItem> _todoListItems;

        public TodoListTestDbRepository()
        {
            _todoListItems = new List<TodoListItem>()
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
        }

        public IEnumerable<TodoListItem> GetTodoList()
        {
            return _todoListItems;
        }

        public TodoListItem GetTodoListItem(int id)
        {
            var item = _todoListItems.Find(x => x.Id == id);
            return item == null ? throw new Exception("Item not found") : item;
        }

        public void Create(TodoListItem request)
        {
            var item = _todoListItems.Find(x => x.Id == request.Id);
            if (item != null)
                throw new Exception($"Item {request.Id} already exist");
            _todoListItems.Add(request);
        }

        public void Update(TodoListItem request)
        {
            var item = _todoListItems.Find(x => x.Id == request.Id);
            if (item == null)
                throw new Exception("Item not found");
            item.TodoTask = request.TodoTask;
            item.IsDone = request.IsDone;
            item.ScheduledTime = request.ScheduledTime;
        }

        public void Delete(int id)
        {
            var item = _todoListItems.Find(x => x.Id == id);
            if (item == null)
                throw new Exception("Item not found");
            _todoListItems.Remove(item);
        }
    }
}
