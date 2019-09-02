using Microsoft.EntityFrameworkCore;
using StorageApp.Core.Interfaces.DataAccessHandlers;
using StorageApp.Core.Models;
using StorageApp.DataAccessHandlers.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace StorageApp.DataAccessHandlers
{
    public abstract class BaseHandler<T> : IBaseHandler<T> where T : class, IBaseEntity
    {

        protected readonly DbSet<T> _dbSet;
        protected readonly DbContext _context;

        public BaseHandler(StorageAppContext context) {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public T GetById(int id)
        {
            return _dbSet.First(e => e.Id == id);
        }
    }
}
