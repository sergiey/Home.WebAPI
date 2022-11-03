using TodoList.Client.Presenters;

namespace TodoList.Client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            try
            {
                var mainPresenter = new MainPresenter(new TodoListForm());
                mainPresenter.ShowView();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}