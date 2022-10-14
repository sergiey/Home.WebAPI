using TodoList.WebApi.Model;

namespace TodoList.Client.Views
{
    public interface IEditView
    {
        public Action<TodoListItem, bool> SaveItem { get; set; }

        public void Close();
        public void Show();
    }
}