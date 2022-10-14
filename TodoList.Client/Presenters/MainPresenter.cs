using System.ComponentModel;
using TodoList.Client.Views;
using TodoList.WebApi.Model;

namespace TodoList.Client.Presenters
{
    public class MainPresenter
    {
        private BindingList<TodoListItem> _bindList;
        private readonly ITodoListView _mainForm;
        private static HttpClient s_client = new();

        public MainPresenter(ITodoListView mainForm)
        {
            _mainForm = mainForm;
            _bindList = new BindingList<TodoListItem>();
            _mainForm.EditItem += (view) => ShowEditView(view);
            _mainForm.DeleteItem += (id) => DeleteItem(id);
            _mainForm.Load += (_, _) => GetData();

            // Set environment variable "Uri" like https://localhost:7153/api/TodoList/
            var uri = Environment.GetEnvironmentVariable("Uri");
            if (uri == null)
                throw new ArgumentNullException("Environment variable \"Uri\" isn't set");
            s_client.BaseAddress = new Uri(uri);
        }

        public void ShowEditView(IEditView editView)
        {
            var editPresenter = new EditPresenter(editView, s_client);
            editPresenter.MainPresenter = this;
            editPresenter.Edit();
        }

        public async void DeleteItem(Guid id)
        {
            var response = await s_client.DeleteAsync(id.ToString());
            if (response.IsSuccessStatusCode)
                GetData();
        }

        public async void GetData()
        {
            try
            {
                var response = await s_client.GetAsync(s_client.BaseAddress);
                if (response.IsSuccessStatusCode)
                    _bindList = await response.Content.
                        ReadAsAsync<BindingList<TodoListItem>>();
                _mainForm.UpdateDataSource(_bindList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void ShowView()
        {
            _mainForm.OpenView();
        }
    }
}
