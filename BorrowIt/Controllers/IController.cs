using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BorrowIt.Controllers
{
    public interface IController<T>
    {
        Task<ICollection<T>> GetAll();
        Task<T>GetById(Guid id);
        [HttpPost]
        ActionResult Create(T entity);
        Task<ActionResult> Delete(Guid id);
        ActionResult Edit(T entity);
    }
}
