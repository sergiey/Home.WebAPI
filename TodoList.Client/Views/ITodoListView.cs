using System.ComponentModel;
using TodoList.WebApi.Model;

namespace TodoList.Client.Views
{
    public interface ITodoListView
    {
        public event EventHandler Load;

        public BindingList<TodoListItem> TodoItemsBindList { get; set; }

        public Action<Guid> DeleteItem { get; set; }
        public Action<IEditView> EditItem { get; set; }
        public Action UpdateTodoList { get; set; }

        public void UpdateDataSource(BindingList<TodoListItem> bindList);
        void OpenView();
    }
}
