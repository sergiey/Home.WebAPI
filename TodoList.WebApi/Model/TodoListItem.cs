namespace TodoList.WebApi.Model
{
    public class TodoListItem
    {
        public int Id { get; set; }

        public string TodoTask { get; set; } = string.Empty;

        public bool IsDone { get; set; } = false;

        public DateTime ScheduledTime { get; set; } = DateTime.Now;
    }
}
