namespace Repositrypattern.API.Repo
{
    public interface IRepository<T> where T : class
    {
        int SaveChanges(T entity);
        Task<T> GetByIdAsync(int id);
    }
}
