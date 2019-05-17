using BusinessLogic.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BorrowIt.Controllers
{
    public abstract class GenericController<T> : ControllerBase, IController<T> where T : BaseClass
    {
        protected readonly IServices<T> _services;

        public GenericController(IServices<T> services)
        {
            _services = services;
        }

        [HttpPost]
        public ActionResult Create(T entity)
        {
            _services.Create(entity);
            return StatusCode(201);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _services.Delete(id);
            return StatusCode(204);
        }

        [HttpPut]
        public ActionResult Edit(T entity)
        {
            _services.Edit(entity);
            return StatusCode(204);
        }

        [HttpGet("{id}")]
        public async Task<T> GetById(Guid id)
        {
            return await _services.GetEntityById(id);
        }

        [HttpGet]
        public async Task<ICollection<T>> GetAll()
        {
            return await _services.GetEntities();
        }
    }
}
