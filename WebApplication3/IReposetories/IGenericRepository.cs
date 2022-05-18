namespace WebApplication3.IReposetories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<bool> Add(T entity);
        Task<bool> Delete(int Id);
        Task<bool> Update(T entity);
        Task<T> Get(int id);
        List<T> Get();
    }
}
