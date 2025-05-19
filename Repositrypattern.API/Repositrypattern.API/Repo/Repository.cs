
using Microsoft.EntityFrameworkCore;

namespace Repositrypattern.API.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            var _res = await _dbSet.FindAsync(id);
            return _res;
        }

        public int SaveChanges(T entity)
        {
            _context.Add(entity);
            int _res = _context.SaveChanges();
            return _res;
        }
    }
}
