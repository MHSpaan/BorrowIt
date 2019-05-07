using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public interface IServices<T> where T : BaseClass
    {
        void Create(T entity);
        Task Delete(Guid id);
        void Edit(T entity);
        Task<ICollection<T>> GetEntities();
        Task<T> GetEntityById(Guid id);
        bool Validate(T entity);
    }
}
