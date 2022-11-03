using System;
using TodoList.Client.Views;
using TodoList.WebApi.Model;

namespace TodoList.Client
{
    public partial class EditItemForm : Form, IEditView
    {
        private readonly bool _isNewItem = true;
        private readonly Guid _id;

        public Action<TodoListItem, bool> SaveItem { get; set; }

        public EditItemForm()
        {
            InitializeComponent();
        }

        public EditItemForm(TodoListItem item) : this()
        {
            _isNewItem = false;
            _id = item.Id;
            taskTextBox.Text = item.TodoTask;
            isDoneCheckBox.Checked = item.IsDone;
            scheduleDateTimePicker.Value = item.ScheduledTime;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var item = new TodoListItem();
            item.Id = _id;
            item.IsDone = isDoneCheckBox.Checked;
            item.TodoTask = taskTextBox.Text;
            item.ScheduledTime = scheduleDateTimePicker.Value;
            SaveItem?.Invoke(item, _isNewItem);
            Close();
        }
    }
}
