using Microsoft.EntityFrameworkCore;
using Repositrypattern.API.Models;

namespace Repositrypattern.API.Repo
{

    // public class ProductRepository :  IProductRepository, Repository<Product>


    /// <summary>
    /// Compared two declartion of ProductRepository class.  Above one is not correct
    /// because it is not inheriting from Repository class.(Repository<Product> is a class, and C# allows only one base class to be inherited.)
    /// IProductRepository is an interface, and you can implement multiple interfaces.
    /// </summary>
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }

    #region crossCheck

    //public class Test
    // {
    //     private readonly ProductRepository productRepository;
    //     public Test(ProductRepository _productRepository)
    //     {
    //         productRepository = _productRepository;
    //     }
    //     public void ABC()
    //     {
    //         var res = productRepository.GetAllProductsAsync();
    //         // Do something with the result
    //     }
    // }
    #endregion

}
