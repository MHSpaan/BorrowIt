using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BorrowIt.Data.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseClass
    {
        protected readonly DbSet<T> _set;
        protected readonly IApplicationDbContext _context;

        public GenericRepository(IApplicationDbContext context, DbSet<T> set)
        {
            _set = set;
            _context = context;
        }

        public void Create(T entity)
        {
            _set.Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
            Save();
        }

        public void Edit(T entity)
        {
            _set.Update(entity);
            Save();
        }

        public async Task<ICollection<T>> GetEntities()
        {
            return await _set.ToListAsync();
        }

        public async Task<T> GetEntityById(Guid id)
        {
            return await _set.FindAsync(id);
        }

        public void Save()
        {
            _context.Save();
        }
    }
}
