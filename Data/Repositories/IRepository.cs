using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BorrowIt.Data.Repositories
{
    public interface IRepository<T> where T : BaseClass
    {
        void Create(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
        Task<ICollection<T>> GetEntities();
        Task<T> GetEntityById(Guid id);
    }
}
