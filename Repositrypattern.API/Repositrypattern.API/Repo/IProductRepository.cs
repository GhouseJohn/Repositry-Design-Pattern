using Repositrypattern.API.Models;

namespace Repositrypattern.API.Repo
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}
