using WebApiVendas.Data.Context;
using WebApiVendas.Models;

namespace WebApiVendas.Controllers
{
    public class CategoriasController : ControllerBase<Categoria>
    {
        public CategoriasController(DataContext context) : base(context)
        {
        }
    }
}