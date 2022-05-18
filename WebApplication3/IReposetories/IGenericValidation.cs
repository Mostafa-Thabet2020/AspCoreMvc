namespace WebApplication3.IReposetories
{
    public interface IGenericValidation<T> where T : class
    {
        bool IsExist(T entity);
        bool IsValid(T entity);
    }
}
