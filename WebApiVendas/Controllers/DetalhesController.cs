using WebApiVendas.Data.Context;
using WebApiVendas.Models;

namespace WebApiVendas.Controllers
{
    public class DetalhesController : ControllerBase<DetalhesPed>
    {
        public DetalhesController(DataContext context) : base(context)
        {
        }
    }
}