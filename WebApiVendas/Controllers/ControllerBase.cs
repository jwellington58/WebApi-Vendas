using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiVendas.Data.Context;
using WebApiVendas.Repositories;

namespace WebApiVendas.Controllers
{
    [Route("api/[controller]/")]
    public abstract class ControllerBase<T> : Controller where T : class
    {
        public RepositoryBase<T> _repository;
        public ControllerBase()
        {
            _repository = new RepositoryBase<T>(new DataContext());
        }
        [HttpGet]
        public virtual IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entity = _repository.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

    }
}