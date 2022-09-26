namespace TodoList.WebApi
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetTodoList();

        T? GetTodoListItem(int id);

        void Create(T item);

        void Update(T item);

        void Delete(int id);
    }
}