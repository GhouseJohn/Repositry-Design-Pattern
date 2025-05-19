
namespace Repositrypattern.API.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProductRepository Products { get; }
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            Products = new ProductRepository(context);
            _context = context;
        }

        public Task<int> CompleteAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
