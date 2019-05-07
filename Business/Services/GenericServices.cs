using BorrowIt.Data.Repositories;
using BusinessLogic.Validators;
using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class GenericServices<T> : IServices<T> where T : BaseClass
    {

        protected readonly IRepository<T> _repository;
        protected readonly IValidator<T> _validator;

        public GenericServices(IRepository<T> repository, IValidator<T> validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public void Create(T entity)
        {
            if (Validate(entity))
            {
                try
                {
                    _repository.Create(entity);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public async Task Delete(Guid id)
        {
            try
            {
                _repository.Delete(await GetEntityById(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Edit(T entity)
        {
            if (Validate(entity))
                try
                {
                    _repository.Edit(entity);
                }
                catch (Exception)
                {
                    throw;
                }
        }

        public async Task<ICollection<T>> GetEntities()
        {
            return await _repository.GetEntities();
        }

        public async Task<T> GetEntityById(Guid id)
        {
            return await _repository.GetEntityById(id);
        }

        public bool Validate(T entity)
        {
            return _validator.IsValid(entity);
        }
    }
}
