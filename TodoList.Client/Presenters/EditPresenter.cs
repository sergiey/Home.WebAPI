using System.Text;
using System.Text.Json;
using TodoList.Client.Views;
using TodoList.WebApi.Model;

namespace TodoList.Client.Presenters
{
    internal class EditPresenter
    {
        private readonly IEditView _view;
        private readonly HttpClient _client;

        public MainPresenter? MainPresenter { get; set; }

        public EditPresenter(IEditView view, HttpClient client)
        {
            _view = view;
            _client = client;
            _view.SaveItem += (item, isNewItem) => SaveItem(item, isNewItem);
        }

        private async void SaveItem(TodoListItem item, bool isNewItem)
        {
            if (item.Id == Guid.Empty)
                item.Id = Guid.NewGuid();

            var json = JsonSerializer.Serialize(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response;

            if (isNewItem)
                response = await _client.PostAsync(_client.BaseAddress, content);
            else
                response = await _client.PutAsync(_client.BaseAddress, content);
            if (!response.IsSuccessStatusCode)
                MessageBox.Show("Data not saved");
            MainPresenter?.GetData();
        }

        internal void Edit()
        {
            _view.Show();
        }
    }
}
