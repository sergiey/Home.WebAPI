namespace TodoList.WebApi.Model
{
    public class TodoListItem
    {
        public Guid Id { get; set; }

        public string TodoTask { get; set; }

        public bool IsDone { get; set; }

        public DateTime ScheduledTime { get; set; }
    }
}
