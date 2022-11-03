using System.ComponentModel;
using TodoList.Client.Views;
using TodoList.WebApi.Model;

namespace TodoList.Client
{
    public partial class TodoListForm : Form, ITodoListView
    {
        public BindingList<TodoListItem> TodoItemsBindList { get; set; }
        public Action<Guid> DeleteItem { get; set; }
        public Action<IEditView> EditItem { get; set; }
        public Action UpdateTodoList { get; set; }

        public TodoListForm()
        {
            InitializeComponent();
            TodoItemsBindList = new BindingList<TodoListItem>();
        }

        public void OpenView()
        {
            Application.Run(this);
        }

        public void UpdateDataSource(BindingList<TodoListItem> bindList)
        {
            TodoItemsBindList = bindList;
            dataGridView1.DataSource = TodoItemsBindList;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditRow();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditRow();
        }

        private void EditRow()
        {
            var item = new TodoListItem()
            {
                Id = Guid.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString()),
                IsDone = Convert.ToBoolean(dataGridView1.CurrentRow.Cells["IsDoneColumn"].Value),
                TodoTask = Convert.ToString(dataGridView1.CurrentRow.Cells["TodoTaskColumn"].Value),
                ScheduledTime = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["ScheduledTimeColumn"].Value)
            };
            var editForm = new EditItemForm(item);
            EditItem?.Invoke(editForm);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            var editForm = new EditItemForm();
            EditItem?.Invoke(editForm);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            DeleteItem?.Invoke(id);
        }

        private void TodoListForm_Load(object sender, EventArgs e)
        {
            TodoItemsBindList = new BindingList<TodoListItem>();
            TodoItemsBindList.AllowNew = true;
            TodoItemsBindList.AllowEdit = true;
            TodoItemsBindList.AllowRemove = true;
            TodoItemsBindList.RaiseListChangedEvents = true;
            dataGridView1.DataSource = TodoItemsBindList;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["IsDoneColumn"].DisplayIndex = 1;
            dataGridView1.Columns["TodoTaskColumn"].DisplayIndex = 2;
            dataGridView1.Columns["ScheduledTimeColumn"].DisplayIndex = 3;
        }
    }
}
