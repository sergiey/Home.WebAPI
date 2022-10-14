namespace TodoList.WebApi
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetTodoList();

        T? GetTodoListItem(Guid id);

        void Create(T item);

        void Update(T item);

        void Delete(Guid id);
    }
}