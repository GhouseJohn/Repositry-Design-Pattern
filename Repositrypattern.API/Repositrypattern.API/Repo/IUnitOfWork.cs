namespace Repositrypattern.API.Repo
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        Task<int> CompleteAsync();
    }
}
