namespace TodoList.WebApi.Model
{
    public class TodoListItem
    {
        public int Id { get; set; }

        public string TodoTask { get; set; }

        public bool IsDone { get; set; }

        public DateTime ScheduledTime { get; set; }
    }
}
